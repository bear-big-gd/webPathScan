using SufeiUtil;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abinjcWebPathBrute
{
  public partial class Form1 : Form
  {

    List<CheckBox> checkboxRequestMethods = new List<CheckBox> { };
    List<string> dics = new List<string>();
    int confTimeout = 0;
    WebHeaderCollection confHeaders = new WebHeaderCollection();
    string confContentType = "text/html", confUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.90 Safari/537.36", proxyUrl = "";
    Dictionary<int, bool> allowPorts = new Dictionary<int, bool> { };
    string[] excludeMsgs = new string[] { };
    BasicControllableThreadPool threadPool;
    ConcurrentQueue<Ret> resultBuffer = new ConcurrentQueue<Ret>();
    System.Windows.Forms.Timer uiUpdateTimer;
    System.Windows.Forms.Timer completionCheckTimer;
    volatile string latestStatus = "";
    long processedItemsCount = 0;
    const int UPDATE_INTERVAL = 100; // 更新间隔（毫秒）
    int STATUS_UPDATE_THRESHOLD = 10; // 状态更新阈值

    private void UiUpdateTimer_Tick(object sender, EventArgs e)
    {
      UpdateUI();
    }

    private void UpdateUI()
    {
      // 更新状态标签
      if (!string.IsNullOrEmpty(latestStatus))
      {
        if (toolStripStatusLabelNowScanPath.Text != latestStatus)
        {
          toolStripStatusLabelNowScanPath.Text = latestStatus;
          // 更新结果计数
          Interlocked.Read(ref processedItemsCount);
          labelResultCount.Text = $"{processedItemsCount}/{dics.Count}";
          groupBoxResult.Text = $"结果 数量({listViewResult.Items.Count})：";
          int percentage = (int)((double)processedItemsCount / dics.Count * 100);
          percentage = Math.Min(100, Math.Max(0, percentage));
          progressBarResult.Value = percentage;
        }
      }

      // 更新ListView
      List<ListViewItem> newItems = new List<ListViewItem>();
      Ret result;
      int count = 0;
      while (resultBuffer.TryDequeue(out result) && count < 100) // 限制每次更新的项目数
      {
        ListViewItem item = new ListViewItem(result.url);
        item.SubItems.Add(result.code.ToString());
        item.SubItems.Add(result.res);
        newItems.Add(item);
        count++;
      }

      if (newItems.Count > 0)
      {
        listViewResult.BeginUpdate();
        listViewResult.Items.AddRange(newItems.ToArray());
        listViewResult.EndUpdate();

        // 如果需要，可以在这里自动滚动到最新项
        if (listViewResult.Items.Count > 0)
        {
          listViewResult.Items[listViewResult.Items.Count - 1].EnsureVisible();
        }
      }
    }

    private void CompletionCheckTimer_Tick(object sender, EventArgs e)
    {
      if (threadPool != null && threadPool.IsAllTasksCompleted())
      {
        completionCheckTimer.Stop();
        this.BeginInvoke((MethodInvoker)delegate
        {
          buttonAttack.Text = "开始";
          buttonStop.Enabled = false;
          toolStripStatusLabelNowScanStatus.Text = "已完成";
          latestStatus = "...";
          MessageBox.Show("扫描已完成！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        });
      }
    }

    public Form1()
    {
      InitializeComponent();
      ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
      SetStyle(ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.UserPaint, true);

      uiUpdateTimer = new System.Windows.Forms.Timer();
      uiUpdateTimer.Interval = UPDATE_INTERVAL;
      uiUpdateTimer.Tick += UiUpdateTimer_Tick;
      uiUpdateTimer.Start();
      checkboxRequestMethods = new List<CheckBox> { checkBoxScanMethodGet, checkBoxScanMethodPost, checkBoxScanMethodHead };
      completionCheckTimer = new System.Windows.Forms.Timer();
      completionCheckTimer.Interval = 1000; // Check every second
      completionCheckTimer.Tick += CompletionCheckTimer_Tick;
      for (int i = 0; i < checkboxRequestMethods.Count; i++)
      {
        checkboxRequestMethods[i].CheckedChanged += checkBoxScanMethodGet_CheckedChanged;
      }
      FormStateSaver.RestoreFormState(this);
    }

    private void CheckBoxScanMethodGet_MouseUp(object sender, MouseEventArgs e)
    {

    }

    private void checkBoxScanMethodGet_CheckedChanged(object sender, EventArgs e)
    {
      CheckBox cb = (CheckBox)sender;
      //这里用checkbox是为了方便以后拓展，如果以后有需求同时扫描多个方式，直接在这里改
      cb.Enabled = false;//设置当前选中项 禁止再次点击
      if (!cb.Checked)
      {
        return;
      }
      for (int i = 0; i < checkboxRequestMethods.Count; i++)
      {
        CheckBox nowCb = checkboxRequestMethods[i];
        if (cb != checkboxRequestMethods[i])
        {
          nowCb.Checked = false;
          nowCb.Enabled = true;
        }
      }
    }

    private void toolStripStatusLabel2_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("explorer.exe", "https://abinjc.vip");
    }

    private void buttonRefreashDic_Click(object sender, EventArgs e)
    {
      LoadDicPaths();
    }

    private void LoadDicPaths()
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "文本文件|*.txt";
      ofd.Title = "请选择字典文件，按ctrl选中就是多选";
      ofd.Multiselect = true;
      ofd.InitialDirectory = Directory.GetCurrentDirectory();
      if (ofd.ShowDialog() != DialogResult.OK)
      {
        return;
      }

      for (int i = 0; i < ofd.FileNames.Length; i++)
      {
        int lineCount = File.ReadAllLines(ofd.FileNames[i]).Length;
        ListViewItem lv = new ListViewItem();
        lv.Text = ofd.FileNames[i];
        lv.SubItems.Add(lv.Text.Substring(lv.Text.LastIndexOf("\\") + 1));
        lv.SubItems.Add(lineCount.ToString());
        if (listViewDic.FindItemWithText(lv.Text) != null) //存在了就不要再插入了
        {
          continue;
        }
        listViewDic.Items.Add(lv);
      }
    }

    private void selectDics(string method)
    {
      Dictionary<string, int> methodDic = new Dictionary<string, int>();
      methodDic.Add("全选", 1);
      methodDic.Add("不选", 2);
      methodDic.Add("反选", 3);
      for (int i = 0; i < listViewDic.Items.Count; i++)
      {
        switch (methodDic[method])
        {
          case 1:
            listViewDic.Items[i].Checked = true; break;
          case 2:
            listViewDic.Items[i].Checked = false; break;
          case 3:
            listViewDic.Items[i].Checked = !listViewDic.Items[i].Checked; break;
        }
      }
    }

    //格式化状态码
    public static Dictionary<int, bool> formatStatusCode(string input)
    {
      List<int> codes = new List<int>();

      string[] parts = input.ToLower().Split('|');

      foreach (string part in parts)
      {
        if (Regex.IsMatch(part, @"^\d{3}$"))
        {
          codes.Add(int.Parse(part));
        }
        else if (Regex.IsMatch(part, @"^\d$"))
        {
          int start = int.Parse(part) * 100;
          codes.AddRange(Enumerable.Range(start, 100));
        }
        else if (Regex.IsMatch(part, @"^\d{1}xx$"))
        {
          int start = int.Parse(part.Substring(0, 1)) * 100;
          codes.AddRange(Enumerable.Range(start, 100));
        }
      }

      Dictionary<int, bool> codeDict = new Dictionary<int, bool>();

      foreach (int code in codes)
      {
        codeDict[code] = true;
      }

      return codeDict;
    }

    public bool ContainsKeyword(string content)
    {
      foreach (string keyword in excludeMsgs)
      {
        if (content.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) != -1 && keyword != "")
        {
          return true;
        }
      }
      return false;
    }

    //线程主方法
    private Ret attack(string url, string method)
    {
      HttpHelper httpHelper = new HttpHelper();

      HttpItem httpItem = new HttpItem()
      {
        URL = url,
        Method = method,
        Timeout = confTimeout,
        Header = confHeaders,
        UserAgent = confUserAgent,
        ContentType = confContentType,
        Postdata = "",
        ProxyIp = proxyUrl,
      };

      HttpResult httpResult = httpHelper.GetHtml(httpItem);

      bool exists = false, isVerify = false;
      int statusCode = (int)httpResult.StatusCode;
      if (allowPorts.TryGetValue(statusCode, out exists))
      {
        isVerify = true;
        if (ContainsKeyword(httpResult.Html))
        {
          isVerify = false;
        }
      }
      return new Ret
      {
        code = ((int)httpResult.StatusCode),
        url = url,
        res = httpResult.Html,
        isVerify = isVerify,
      };
    }

    private void startAttack()
    {
      labelResultCount.Text = $"0/{dics.Count}";
      int threadNum = int.Parse(textBoxScanThreadNum.Text);
      int delayMs = int.Parse(textBoxDelay.Text);
      confTimeout = int.Parse(textBoxTimeout.Text);
      string[] headers = textBoxRequestHeader.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
      string baseUrl = textBoxTarget.Text;
      allowPorts = formatStatusCode(textBoxRetStatusCode.Text);
      excludeMsgs = textBoxExcludeRetMsg.Text.Split('|');
      proxyUrl = textBoxProxyUrl.Text;
      for (int i = 0; i < headers.Length; i++)
      {
        string[] ps = headers[i].Split(new string[] { ":" }, StringSplitOptions.None);
        ps[0] = ps[0].Trim();
        if (ps.Length == 1)
        {
          continue;
        }
        ps[1] = ps[1].Trim();
        if (ps[0] == "Content-Type")
        {
          confContentType = ps[1];
          continue;
        }
        if (ps[0] == "User-Agent")
        {
          confUserAgent = ps[1];
          continue;
        }
        confHeaders.Add(ps[0], ps[1].Trim());
      }

      string reqMethod = checkboxRequestMethods.Where(it => it.Checked == true).ToArray().First().Text;

      threadPool = new BasicControllableThreadPool(threadNum, delayMs);

      bool isAppend = baseUrl.IndexOf("{路径}") == -1;

      if (dics.Count < 100)
      {
        STATUS_UPDATE_THRESHOLD = 1;
      }
      else
      {
        STATUS_UPDATE_THRESHOLD = 10;
      }
      for (int i = 0; i < dics.Count; i++)
      {
        int index = i;
        threadPool.QueueTask(
                task: (updateCallback) =>
                {
                  Ret result = null;
                  if (isAppend)
                  {
                    result = attack(baseUrl + dics[index], reqMethod);
                  }
                  else
                  {
                    result = attack(baseUrl.Replace("{路径}", dics[index]), reqMethod);
                  }
                  long currentCount = Interlocked.Increment(ref processedItemsCount);
                  if (currentCount % STATUS_UPDATE_THRESHOLD == 0)
                  {
                    latestStatus = $"{result.url}|{result.code}";
                  }

                  if (result.isVerify)
                  {
                    resultBuffer.Enqueue(result);
                  }
                },
                callback: (result) =>
                {

                }
            );
      }

      threadPool.Start();
    }

    private void buttonAttack_Click(object sender, EventArgs e)
    {
      if (buttonAttack.Text == "开始")
      {
        dics.Clear();
        for (int i = 0; i < listViewDic.Items.Count; i++)
        {
          if (!listViewDic.Items[i].Checked)
          {
            continue;
          }
          string path = listViewDic.Items[i].Text;
          string[] datas = File.ReadAllLines(path);
          dics.AddRange(datas);
        }
        if (dics.Count == 0)
        {
          MessageBox.Show("字典行数为0，请选择字典后再使用");
          return;
        }
        listViewResult.Items.Clear();
        processedItemsCount = 0;
        buttonStop.Enabled = true;
        toolStripStatusLabelNowScanStatus.Text = "运行中";
        buttonAttack.Text = "暂停";
        completionCheckTimer.Start();
        startAttack();
      }
      else if (buttonAttack.Text == "暂停")
      {
        buttonAttack.Text = "继续";
        toolStripStatusLabelNowScanStatus.Text = "暂停中";
        threadPool.Pause();
      }
      else if (buttonAttack.Text == "继续")
      {
        buttonAttack.Text = "暂停";
        toolStripStatusLabelNowScanStatus.Text = "运行中";
        threadPool.Resume();
      }
    }

    private void buttonStop_Click(object sender, EventArgs e)
    {
      if (threadPool != null)
      {
        threadPool.Stop();
        threadPool.Dispose();
        threadPool = null;
      }
      completionCheckTimer.Stop();
      buttonStop.Enabled = false;
      buttonAttack.Text = "开始";
      toolStripStatusLabelNowScanStatus.Text = "已停止";
    }

    private void buttonDicSelectAll_Click(object sender, EventArgs e)
    {
      selectDics("全选");
    }

    private void buttonDicUnSelectAll_Click(object sender, EventArgs e)
    {
      selectDics("反选");
    }

    private void buttonDicNoSelectAll_Click(object sender, EventArgs e)
    {
      selectDics("不选");
    }

    private void textBoxTarget_TextChanged(object sender, EventArgs e)
    {

    }

    private void buttonClearDic_Click(object sender, EventArgs e)
    {
      listViewDic.Items.Clear();
    }

    private void listViewResult_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      ListView listview = (ListView)sender;
      ListViewItem lstrow = listview.GetItemAt(e.X, e.Y);
      System.Windows.Forms.ListViewItem.ListViewSubItem lstcol = lstrow.GetSubItemAt(e.X, e.Y);
      string strText = lstcol.Text;
      try
      {
        Clipboard.SetDataObject(strText);
      }
      catch (System.Exception ex)
      {
        MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      FormStateSaver.SaveFormState(this);
      try
      {
        if (threadPool != null)
        {
          threadPool.Stop();
          threadPool.Dispose();
        }
        uiUpdateTimer.Stop();
        completionCheckTimer.Stop();
      }
      catch (Exception)
      {

      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
