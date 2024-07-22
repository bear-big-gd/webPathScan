using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace abinjcWebPathBrute
{
  public class Ret
  {
    public int code;
    public string url;
    public string res;
    public bool isVerify; // 是否通过验证
  }

  public class TaskItem
  {
    public Action<Action<Ret>> Task { get; set; }
    public Action<Ret> Callback { get; set; }
  }

  public class BasicControllableThreadPool : IDisposable
  {
    private int _totalTasks;
    private int _completedTasks;
    private readonly Queue<TaskItem> _taskQueue;
    private readonly Thread[] _workers;
    private readonly int _delayMilliseconds;
    private volatile bool _isRunning;
    private volatile bool _isPaused;
    private volatile bool _isDisposed;
    private readonly object _lockObject = new object();
    private readonly ManualResetEventSlim _pauseEvent = new ManualResetEventSlim(true);

    public BasicControllableThreadPool(int threadCount, int delayMilliseconds)
    {
      if (threadCount <= 0)
        throw new ArgumentException("线程数量不能小于等于0", nameof(threadCount));

      if (delayMilliseconds < 0)
        throw new ArgumentException("延迟时间不能小于0", nameof(delayMilliseconds));

      _taskQueue = new Queue<TaskItem>();
      _workers = new Thread[threadCount];
      _delayMilliseconds = delayMilliseconds;
      _isRunning = false;
      _isPaused = false;

      for (int i = 0; i < threadCount; i++)
      {
        _workers[i] = new Thread(Worker)
        {
          IsBackground = true,
          Name = $"ThreadPool-Worker-{i}"
        };
        _workers[i].Start();
      }
    }

    public void Start()
    {
      if (_isDisposed)
        throw new ObjectDisposedException(nameof(BasicControllableThreadPool));

      _isRunning = true;
      _isPaused = false;
      _pauseEvent.Set();
      Console.WriteLine("线程池开始");
    }

    public void Stop()
    {
      if (_isDisposed)
        throw new ObjectDisposedException(nameof(BasicControllableThreadPool));

      _isRunning = false;
      _isPaused = false;
      _pauseEvent.Set();
      Console.WriteLine("线程池停止");
    }

    public void Pause()
    {
      if (_isDisposed)
        throw new ObjectDisposedException(nameof(BasicControllableThreadPool));

      if (_isRunning && !_isPaused)
      {
        _isPaused = true;
        _pauseEvent.Reset();
        Console.WriteLine("线程池暂停");
      }
    }

    public void Resume()
    {
      if (_isDisposed)
        throw new ObjectDisposedException(nameof(BasicControllableThreadPool));

      if (_isRunning && _isPaused)
      {
        _isPaused = false;
        _pauseEvent.Set();
        Console.WriteLine("线程池恢复");
      }
    }

    public void Reset()
    {
      lock (_lockObject)
      {
        _totalTasks = 0;
        _completedTasks = 0;
        _taskQueue.Clear();
      }
    }

    public void QueueTask(Action<Action<Ret>> task, Action<Ret> callback)
    {
      if (_isDisposed)
        throw new ObjectDisposedException(nameof(BasicControllableThreadPool));

      lock (_lockObject)
      {
        _taskQueue.Enqueue(new TaskItem { Task = task, Callback = callback });
        Interlocked.Increment(ref _totalTasks);
      }
    }

    private void Worker()
    {
      while (!_isDisposed)
      {
        _pauseEvent.Wait();
        if (!_isRunning) continue;

        TaskItem item = null;
        lock (_lockObject)
        {
          if (_taskQueue.Count > 0)
          {
            item = _taskQueue.Dequeue();
          }
        }

        if (item != null)
        {
          try
          {
            item.Task(result =>
            {
              if (item.Callback != null)
              {
                item.Callback(result);
              }
            });
          }
          finally
          {
            Interlocked.Increment(ref _completedTasks);
          }
          Thread.Sleep(_delayMilliseconds);
        }
        else
        {
          Thread.Sleep(100);  // Sleep when no tasks are available
        }
      }
    }

    public bool IsAllTasksCompleted()
    {
      return _totalTasks > 0 && _totalTasks == _completedTasks;
    }

    public void Dispose()
    {
      if (_isDisposed)
        return;

      _isDisposed = true;
      _isRunning = false;
      _isPaused = false;
      _pauseEvent.Set();

      foreach (var worker in _workers)
      {
        worker.Join();
      }

      _pauseEvent.Dispose();
    }
  }
}