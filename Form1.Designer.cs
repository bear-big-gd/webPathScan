namespace abinjcWebPathBrute
{
  partial class Form1
  {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.groupBoxParams = new System.Windows.Forms.GroupBox();
      this.buttonStop = new System.Windows.Forms.Button();
      this.textBoxExcludeRetMsg = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.textBoxRetStatusCode = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textBoxProxyUrl = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBoxTarget = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.buttonAttack = new System.Windows.Forms.Button();
      this.textBoxDelay = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.checkBoxScanMethodHead = new System.Windows.Forms.CheckBox();
      this.checkBoxScanMethodPost = new System.Windows.Forms.CheckBox();
      this.checkBoxScanMethodGet = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.textBoxRequestHeader = new System.Windows.Forms.TextBox();
      this.textBoxTimeout = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxScanThreadNum = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.listViewDic = new System.Windows.Forms.ListView();
      this.columnsDicPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnDicNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.groupBoxResult = new System.Windows.Forms.GroupBox();
      this.labelResultCount = new System.Windows.Forms.Label();
      this.progressBarResult = new System.Windows.Forms.ProgressBar();
      this.listViewResult = new System.Windows.Forms.ListView();
      this.columnDir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnRetCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnRetMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.buttonRefreashDic = new System.Windows.Forms.Button();
      this.buttonDicSelectAll = new System.Windows.Forms.Button();
      this.buttonDicUnSelectAll = new System.Windows.Forms.Button();
      this.buttonDicNoSelectAll = new System.Windows.Forms.Button();
      this.buttonClearDic = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabelNowScanStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabelNowScanPath = new System.Windows.Forms.ToolStripStatusLabel();
      this.groupBoxParams.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBoxResult.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBoxParams
      // 
      this.groupBoxParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxParams.Controls.Add(this.buttonStop);
      this.groupBoxParams.Controls.Add(this.textBoxExcludeRetMsg);
      this.groupBoxParams.Controls.Add(this.label8);
      this.groupBoxParams.Controls.Add(this.textBoxRetStatusCode);
      this.groupBoxParams.Controls.Add(this.label7);
      this.groupBoxParams.Controls.Add(this.textBoxProxyUrl);
      this.groupBoxParams.Controls.Add(this.label6);
      this.groupBoxParams.Controls.Add(this.textBoxTarget);
      this.groupBoxParams.Controls.Add(this.label5);
      this.groupBoxParams.Controls.Add(this.buttonAttack);
      this.groupBoxParams.Controls.Add(this.textBoxDelay);
      this.groupBoxParams.Controls.Add(this.label4);
      this.groupBoxParams.Controls.Add(this.checkBoxScanMethodHead);
      this.groupBoxParams.Controls.Add(this.checkBoxScanMethodPost);
      this.groupBoxParams.Controls.Add(this.checkBoxScanMethodGet);
      this.groupBoxParams.Controls.Add(this.label3);
      this.groupBoxParams.Controls.Add(this.groupBox2);
      this.groupBoxParams.Controls.Add(this.textBoxTimeout);
      this.groupBoxParams.Controls.Add(this.label2);
      this.groupBoxParams.Controls.Add(this.textBoxScanThreadNum);
      this.groupBoxParams.Controls.Add(this.label1);
      this.groupBoxParams.Location = new System.Drawing.Point(8, 12);
      this.groupBoxParams.Name = "groupBoxParams";
      this.groupBoxParams.Size = new System.Drawing.Size(646, 338);
      this.groupBoxParams.TabIndex = 0;
      this.groupBoxParams.TabStop = false;
      this.groupBoxParams.Text = "参数配置：";
      // 
      // buttonStop
      // 
      this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonStop.Enabled = false;
      this.buttonStop.Location = new System.Drawing.Point(551, 72);
      this.buttonStop.Name = "buttonStop";
      this.buttonStop.Size = new System.Drawing.Size(75, 30);
      this.buttonStop.TabIndex = 20;
      this.buttonStop.Text = "停止";
      this.buttonStop.UseVisualStyleBackColor = true;
      this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
      // 
      // textBoxExcludeRetMsg
      // 
      this.textBoxExcludeRetMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxExcludeRetMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxExcludeRetMsg.Location = new System.Drawing.Point(185, 139);
      this.textBoxExcludeRetMsg.Name = "textBoxExcludeRetMsg";
      this.textBoxExcludeRetMsg.Size = new System.Drawing.Size(449, 23);
      this.textBoxExcludeRetMsg.TabIndex = 19;
      this.textBoxExcludeRetMsg.Text = "认证失败|错误";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(8, 141);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(127, 17);
      this.label8.TabIndex = 18;
      this.label8.Text = "排除返回内容 | 隔开：";
      // 
      // textBoxRetStatusCode
      // 
      this.textBoxRetStatusCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxRetStatusCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxRetStatusCode.Location = new System.Drawing.Point(185, 109);
      this.textBoxRetStatusCode.Name = "textBoxRetStatusCode";
      this.textBoxRetStatusCode.Size = new System.Drawing.Size(449, 23);
      this.textBoxRetStatusCode.TabIndex = 17;
      this.textBoxRetStatusCode.Text = "200|3xx|401|403|405|406|5xx";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(8, 111);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(179, 17);
      this.label7.TabIndex = 16;
      this.label7.Text = "返回状态码 | 隔开 xx代表任意：";
      // 
      // textBoxProxyUrl
      // 
      this.textBoxProxyUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxProxyUrl.Location = new System.Drawing.Point(252, 76);
      this.textBoxProxyUrl.Name = "textBoxProxyUrl";
      this.textBoxProxyUrl.Size = new System.Drawing.Size(186, 23);
      this.textBoxProxyUrl.TabIndex = 15;
      this.textBoxProxyUrl.Text = "127.0.0.1:3000";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(188, 79);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(68, 17);
      this.label6.TabIndex = 14;
      this.label6.Text = "代理地址：";
      // 
      // textBoxTarget
      // 
      this.textBoxTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxTarget.Location = new System.Drawing.Point(240, 18);
      this.textBoxTarget.Name = "textBoxTarget";
      this.textBoxTarget.Size = new System.Drawing.Size(394, 23);
      this.textBoxTarget.TabIndex = 13;
      this.textBoxTarget.Text = "https://xxx.com/{路径}";
      this.textBoxTarget.TextChanged += new System.EventHandler(this.textBoxTarget_TextChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(7, 21);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(233, 17);
      this.label5.TabIndex = 12;
      this.label5.Text = "扫描目标(格式：https://xxx.com/{路径}：";
      // 
      // buttonAttack
      // 
      this.buttonAttack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonAttack.Location = new System.Drawing.Point(470, 72);
      this.buttonAttack.Name = "buttonAttack";
      this.buttonAttack.Size = new System.Drawing.Size(75, 30);
      this.buttonAttack.TabIndex = 11;
      this.buttonAttack.Text = "开始";
      this.buttonAttack.UseVisualStyleBackColor = true;
      this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
      // 
      // textBoxDelay
      // 
      this.textBoxDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxDelay.Location = new System.Drawing.Point(132, 77);
      this.textBoxDelay.Name = "textBoxDelay";
      this.textBoxDelay.Size = new System.Drawing.Size(50, 23);
      this.textBoxDelay.TabIndex = 10;
      this.textBoxDelay.Text = "0";
      this.textBoxDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(8, 79);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(124, 17);
      this.label4.TabIndex = 9;
      this.label4.Text = "每次请求延时(毫秒)：";
      // 
      // checkBoxScanMethodHead
      // 
      this.checkBoxScanMethodHead.AutoSize = true;
      this.checkBoxScanMethodHead.Location = new System.Drawing.Point(454, 48);
      this.checkBoxScanMethodHead.Name = "checkBoxScanMethodHead";
      this.checkBoxScanMethodHead.Size = new System.Drawing.Size(60, 21);
      this.checkBoxScanMethodHead.TabIndex = 8;
      this.checkBoxScanMethodHead.Text = "HEAD";
      this.checkBoxScanMethodHead.UseVisualStyleBackColor = true;
      // 
      // checkBoxScanMethodPost
      // 
      this.checkBoxScanMethodPost.AutoSize = true;
      this.checkBoxScanMethodPost.Location = new System.Drawing.Point(390, 48);
      this.checkBoxScanMethodPost.Name = "checkBoxScanMethodPost";
      this.checkBoxScanMethodPost.Size = new System.Drawing.Size(58, 21);
      this.checkBoxScanMethodPost.TabIndex = 7;
      this.checkBoxScanMethodPost.Text = "POST";
      this.checkBoxScanMethodPost.UseVisualStyleBackColor = true;
      // 
      // checkBoxScanMethodGet
      // 
      this.checkBoxScanMethodGet.AutoSize = true;
      this.checkBoxScanMethodGet.Checked = true;
      this.checkBoxScanMethodGet.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxScanMethodGet.Enabled = false;
      this.checkBoxScanMethodGet.Location = new System.Drawing.Point(334, 48);
      this.checkBoxScanMethodGet.Name = "checkBoxScanMethodGet";
      this.checkBoxScanMethodGet.Size = new System.Drawing.Size(50, 21);
      this.checkBoxScanMethodGet.TabIndex = 6;
      this.checkBoxScanMethodGet.Text = "GET";
      this.checkBoxScanMethodGet.UseVisualStyleBackColor = true;
      this.checkBoxScanMethodGet.CheckedChanged += new System.EventHandler(this.checkBoxScanMethodGet_CheckedChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(273, 49);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 17);
      this.label3.TabIndex = 5;
      this.label3.Text = "扫描方式：";
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.textBoxRequestHeader);
      this.groupBox2.Location = new System.Drawing.Point(6, 167);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(634, 165);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "自定义请求头：";
      // 
      // textBoxRequestHeader
      // 
      this.textBoxRequestHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxRequestHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxRequestHeader.Location = new System.Drawing.Point(5, 22);
      this.textBoxRequestHeader.Multiline = true;
      this.textBoxRequestHeader.Name = "textBoxRequestHeader";
      this.textBoxRequestHeader.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxRequestHeader.Size = new System.Drawing.Size(623, 137);
      this.textBoxRequestHeader.TabIndex = 0;
      this.textBoxRequestHeader.Text = "User-Agent : Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML," +
    " like Gecko) Chrome/60.0.3112.90 Safari/537.36\r\nToken: 123";
      this.textBoxRequestHeader.WordWrap = false;
      // 
      // textBoxTimeout
      // 
      this.textBoxTimeout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxTimeout.Location = new System.Drawing.Point(225, 47);
      this.textBoxTimeout.Name = "textBoxTimeout";
      this.textBoxTimeout.Size = new System.Drawing.Size(42, 23);
      this.textBoxTimeout.TabIndex = 3;
      this.textBoxTimeout.Text = "10000";
      this.textBoxTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(129, 50);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 17);
      this.label2.TabIndex = 2;
      this.label2.Text = "超时时间(毫秒)：";
      // 
      // textBoxScanThreadNum
      // 
      this.textBoxScanThreadNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxScanThreadNum.Location = new System.Drawing.Point(81, 47);
      this.textBoxScanThreadNum.Name = "textBoxScanThreadNum";
      this.textBoxScanThreadNum.Size = new System.Drawing.Size(42, 23);
      this.textBoxScanThreadNum.TabIndex = 1;
      this.textBoxScanThreadNum.Text = "10";
      this.textBoxScanThreadNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 50);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "并发线程数：";
      // 
      // listViewDic
      // 
      this.listViewDic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listViewDic.CheckBoxes = true;
      this.listViewDic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnsDicPath,
            this.columnFileName,
            this.columnDicNum});
      this.listViewDic.FullRowSelect = true;
      this.listViewDic.HideSelection = false;
      this.listViewDic.Location = new System.Drawing.Point(661, 44);
      this.listViewDic.Name = "listViewDic";
      this.listViewDic.Size = new System.Drawing.Size(331, 306);
      this.listViewDic.TabIndex = 1;
      this.listViewDic.UseCompatibleStateImageBehavior = false;
      this.listViewDic.View = System.Windows.Forms.View.Details;
      // 
      // columnsDicPath
      // 
      this.columnsDicPath.Text = "字典路径";
      // 
      // columnFileName
      // 
      this.columnFileName.Text = "字典名称";
      this.columnFileName.Width = 180;
      // 
      // columnDicNum
      // 
      this.columnDicNum.Text = "行数";
      this.columnDicNum.Width = 80;
      // 
      // groupBoxResult
      // 
      this.groupBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxResult.Controls.Add(this.labelResultCount);
      this.groupBoxResult.Controls.Add(this.progressBarResult);
      this.groupBoxResult.Controls.Add(this.listViewResult);
      this.groupBoxResult.Location = new System.Drawing.Point(8, 357);
      this.groupBoxResult.Name = "groupBoxResult";
      this.groupBoxResult.Size = new System.Drawing.Size(984, 319);
      this.groupBoxResult.TabIndex = 2;
      this.groupBoxResult.TabStop = false;
      this.groupBoxResult.Text = "结果 数量(0)：";
      // 
      // labelResultCount
      // 
      this.labelResultCount.AutoSize = true;
      this.labelResultCount.Location = new System.Drawing.Point(504, 3);
      this.labelResultCount.Name = "labelResultCount";
      this.labelResultCount.Size = new System.Drawing.Size(27, 17);
      this.labelResultCount.TabIndex = 7;
      this.labelResultCount.Text = "0/0";
      // 
      // progressBarResult
      // 
      this.progressBarResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBarResult.Location = new System.Drawing.Point(132, -6);
      this.progressBarResult.Name = "progressBarResult";
      this.progressBarResult.Size = new System.Drawing.Size(846, 27);
      this.progressBarResult.TabIndex = 6;
      // 
      // listViewResult
      // 
      this.listViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDir,
            this.columnRetCode,
            this.columnRetMsg});
      this.listViewResult.FullRowSelect = true;
      this.listViewResult.HideSelection = false;
      this.listViewResult.Location = new System.Drawing.Point(11, 23);
      this.listViewResult.Name = "listViewResult";
      this.listViewResult.Size = new System.Drawing.Size(966, 283);
      this.listViewResult.TabIndex = 0;
      this.listViewResult.UseCompatibleStateImageBehavior = false;
      this.listViewResult.View = System.Windows.Forms.View.Details;
      // 
      // columnDir
      // 
      this.columnDir.Text = "路径";
      this.columnDir.Width = 300;
      // 
      // columnRetCode
      // 
      this.columnRetCode.Text = "状态码";
      // 
      // columnRetMsg
      // 
      this.columnRetMsg.Text = "返回内容";
      this.columnRetMsg.Width = 200;
      // 
      // buttonRefreashDic
      // 
      this.buttonRefreashDic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonRefreashDic.Location = new System.Drawing.Point(910, 17);
      this.buttonRefreashDic.Name = "buttonRefreashDic";
      this.buttonRefreashDic.Size = new System.Drawing.Size(82, 23);
      this.buttonRefreashDic.TabIndex = 4;
      this.buttonRefreashDic.Text = "添加字典";
      this.buttonRefreashDic.UseVisualStyleBackColor = true;
      this.buttonRefreashDic.Click += new System.EventHandler(this.buttonRefreashDic_Click);
      // 
      // buttonDicSelectAll
      // 
      this.buttonDicSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonDicSelectAll.Location = new System.Drawing.Point(661, 17);
      this.buttonDicSelectAll.Name = "buttonDicSelectAll";
      this.buttonDicSelectAll.Size = new System.Drawing.Size(55, 23);
      this.buttonDicSelectAll.TabIndex = 5;
      this.buttonDicSelectAll.Text = "全选";
      this.buttonDicSelectAll.UseVisualStyleBackColor = true;
      this.buttonDicSelectAll.Click += new System.EventHandler(this.buttonDicSelectAll_Click);
      // 
      // buttonDicUnSelectAll
      // 
      this.buttonDicUnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonDicUnSelectAll.Location = new System.Drawing.Point(722, 17);
      this.buttonDicUnSelectAll.Name = "buttonDicUnSelectAll";
      this.buttonDicUnSelectAll.Size = new System.Drawing.Size(55, 23);
      this.buttonDicUnSelectAll.TabIndex = 6;
      this.buttonDicUnSelectAll.Text = "反选";
      this.buttonDicUnSelectAll.UseVisualStyleBackColor = true;
      this.buttonDicUnSelectAll.Click += new System.EventHandler(this.buttonDicUnSelectAll_Click);
      // 
      // buttonDicNoSelectAll
      // 
      this.buttonDicNoSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonDicNoSelectAll.Location = new System.Drawing.Point(783, 17);
      this.buttonDicNoSelectAll.Name = "buttonDicNoSelectAll";
      this.buttonDicNoSelectAll.Size = new System.Drawing.Size(55, 23);
      this.buttonDicNoSelectAll.TabIndex = 7;
      this.buttonDicNoSelectAll.Text = "不选";
      this.buttonDicNoSelectAll.UseVisualStyleBackColor = true;
      this.buttonDicNoSelectAll.Click += new System.EventHandler(this.buttonDicNoSelectAll_Click);
      // 
      // buttonClearDic
      // 
      this.buttonClearDic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonClearDic.Location = new System.Drawing.Point(852, 17);
      this.buttonClearDic.Name = "buttonClearDic";
      this.buttonClearDic.Size = new System.Drawing.Size(52, 23);
      this.buttonClearDic.TabIndex = 8;
      this.buttonClearDic.Text = "清空";
      this.buttonClearDic.UseVisualStyleBackColor = true;
      this.buttonClearDic.Click += new System.EventHandler(this.buttonClearDic_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelNowScanStatus,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelNowScanPath});
      this.statusStrip1.Location = new System.Drawing.Point(0, 666);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
      this.statusStrip1.TabIndex = 9;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
      this.toolStripStatusLabel1.Text = "状态：";
      // 
      // toolStripStatusLabelNowScanStatus
      // 
      this.toolStripStatusLabelNowScanStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.toolStripStatusLabelNowScanStatus.Name = "toolStripStatusLabelNowScanStatus";
      this.toolStripStatusLabelNowScanStatus.Size = new System.Drawing.Size(44, 17);
      this.toolStripStatusLabelNowScanStatus.Text = "待开始";
      // 
      // toolStripStatusLabel3
      // 
      this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
      this.toolStripStatusLabel3.Size = new System.Drawing.Size(92, 17);
      this.toolStripStatusLabel3.Text = "当前已运行到：";
      // 
      // toolStripStatusLabelNowScanPath
      // 
      this.toolStripStatusLabelNowScanPath.Name = "toolStripStatusLabelNowScanPath";
      this.toolStripStatusLabelNowScanPath.Size = new System.Drawing.Size(17, 17);
      this.toolStripStatusLabelNowScanPath.Text = "...";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1004, 688);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.buttonClearDic);
      this.Controls.Add(this.buttonDicNoSelectAll);
      this.Controls.Add(this.buttonDicUnSelectAll);
      this.Controls.Add(this.buttonDicSelectAll);
      this.Controls.Add(this.buttonRefreashDic);
      this.Controls.Add(this.groupBoxResult);
      this.Controls.Add(this.listViewDic);
      this.Controls.Add(this.groupBoxParams);
      this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form1";
      this.Text = "阿斌讲程(abinjc.vip)-路径扫描工具 V1.0.1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBoxParams.ResumeLayout(false);
      this.groupBoxParams.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBoxResult.ResumeLayout(false);
      this.groupBoxResult.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBoxParams;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox textBoxRequestHeader;
    private System.Windows.Forms.TextBox textBoxTimeout;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxScanThreadNum;
    private System.Windows.Forms.CheckBox checkBoxScanMethodHead;
    private System.Windows.Forms.CheckBox checkBoxScanMethodPost;
    private System.Windows.Forms.CheckBox checkBoxScanMethodGet;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxDelay;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ListView listViewDic;
    private System.Windows.Forms.ColumnHeader columnsDicPath;
    private System.Windows.Forms.ColumnHeader columnDicNum;
    private System.Windows.Forms.Button buttonAttack;
    private System.Windows.Forms.GroupBox groupBoxResult;
    private System.Windows.Forms.ListView listViewResult;
    private System.Windows.Forms.ColumnHeader columnDir;
    private System.Windows.Forms.ColumnHeader columnRetCode;
    private System.Windows.Forms.ColumnHeader columnRetMsg;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBoxTarget;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBoxProxyUrl;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBoxRetStatusCode;
    private System.Windows.Forms.TextBox textBoxExcludeRetMsg;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button buttonRefreashDic;
    private System.Windows.Forms.ProgressBar progressBarResult;
    private System.Windows.Forms.Button buttonDicSelectAll;
    private System.Windows.Forms.Button buttonDicUnSelectAll;
    private System.Windows.Forms.Button buttonDicNoSelectAll;
    private System.Windows.Forms.Label labelResultCount;
    private System.Windows.Forms.ColumnHeader columnFileName;
    private System.Windows.Forms.Button buttonClearDic;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNowScanStatus;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNowScanPath;
    private System.Windows.Forms.Button buttonStop;
  }
}

