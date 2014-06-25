/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014/6/19
 * 时间: 10:09
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace CodeTemplater
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			_conn.Dispose();
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.tbtnRunTemplate = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.panelData = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panelDataAndGrid = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtData = new System.Windows.Forms.TextBox();
			this.panelPaddingData = new System.Windows.Forms.Panel();
			this.toolStripData = new System.Windows.Forms.ToolStrip();
			this.tbtnPasteData = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txtColumnSpliter = new System.Windows.Forms.ToolStripTextBox();
			this.tbtnConvertDategrid = new System.Windows.Forms.ToolStripButton();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtScript = new System.Windows.Forms.RichTextBox();
			this.panelPaddingScript = new System.Windows.Forms.Panel();
			this.toolStripFileGenerate = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
			this.tcmbFilenameTemplate = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
			this.tcmbFilePath = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.tbtnGenerateFile = new System.Windows.Forms.ToolStripButton();
			this.toolStripCodeSnippet = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.tcmbCodeSnippet = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripTemplate = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.tcmbScript = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tbtnScriptRun = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tbtnScriptSave = new System.Windows.Forms.ToolStripButton();
			this.tbtnScriptDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.panelPaddingResult = new System.Windows.Forms.Panel();
			this.toolStripResult = new System.Windows.Forms.ToolStrip();
			this.tbtnCopyResult = new System.Windows.Forms.ToolStripButton();
			this.toolStripMain.SuspendLayout();
			this.panelData.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panelDataAndGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panelPaddingData.SuspendLayout();
			this.toolStripData.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panelPaddingScript.SuspendLayout();
			this.toolStripFileGenerate.SuspendLayout();
			this.toolStripCodeSnippet.SuspendLayout();
			this.toolStripTemplate.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.panelPaddingResult.SuspendLayout();
			this.toolStripResult.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripMain
			// 
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tbtnRunTemplate});
			this.toolStripMain.Location = new System.Drawing.Point(0, 0);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Size = new System.Drawing.Size(551, 25);
			this.toolStripMain.TabIndex = 1;
			this.toolStripMain.Text = "toolStrip1";
			// 
			// tbtnRunTemplate
			// 
			this.tbtnRunTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tbtnRunTemplate.Image")));
			this.tbtnRunTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtnRunTemplate.Name = "tbtnRunTemplate";
			this.tbtnRunTemplate.Size = new System.Drawing.Size(76, 22);
			this.tbtnRunTemplate.Text = "模板替换";
			this.tbtnRunTemplate.Click += new System.EventHandler(this.TbtnRunTemplateClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 317);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(551, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// panelData
			// 
			this.panelData.Controls.Add(this.tabControl1);
			this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelData.Location = new System.Drawing.Point(0, 25);
			this.panelData.Name = "panelData";
			this.panelData.Size = new System.Drawing.Size(551, 292);
			this.panelData.TabIndex = 4;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(551, 292);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panelDataAndGrid);
			this.tabPage1.Controls.Add(this.panelPaddingData);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(543, 266);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "数据";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panelDataAndGrid
			// 
			this.panelDataAndGrid.BackColor = System.Drawing.Color.Transparent;
			this.panelDataAndGrid.Controls.Add(this.dataGridView1);
			this.panelDataAndGrid.Controls.Add(this.txtData);
			this.panelDataAndGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDataAndGrid.Location = new System.Drawing.Point(3, 30);
			this.panelDataAndGrid.Name = "panelDataAndGrid";
			this.panelDataAndGrid.Size = new System.Drawing.Size(537, 233);
			this.panelDataAndGrid.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(221, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(316, 233);
			this.dataGridView1.TabIndex = 1;
			// 
			// txtData
			// 
			this.txtData.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtData.Location = new System.Drawing.Point(0, 0);
			this.txtData.Multiline = true;
			this.txtData.Name = "txtData";
			this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtData.Size = new System.Drawing.Size(221, 233);
			this.txtData.TabIndex = 0;
			this.txtData.Text = "id\tID\r\nuseragent\t浏览器\r\nip\tIP\r\nmodule\t模块\r\ndata\t数据\r\ncreated\t创建日期\r\nupdated\t修改日期";
			this.txtData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDataKeyDown);
			// 
			// panelPaddingData
			// 
			this.panelPaddingData.Controls.Add(this.toolStripData);
			this.panelPaddingData.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelPaddingData.Location = new System.Drawing.Point(3, 3);
			this.panelPaddingData.Name = "panelPaddingData";
			this.panelPaddingData.Size = new System.Drawing.Size(537, 27);
			this.panelPaddingData.TabIndex = 0;
			// 
			// toolStripData
			// 
			this.toolStripData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tbtnPasteData,
									this.toolStripSeparator2,
									this.toolStripLabel1,
									this.txtColumnSpliter,
									this.tbtnConvertDategrid});
			this.toolStripData.Location = new System.Drawing.Point(0, 0);
			this.toolStripData.Name = "toolStripData";
			this.toolStripData.Size = new System.Drawing.Size(537, 25);
			this.toolStripData.TabIndex = 2;
			this.toolStripData.Text = "toolStrip4";
			// 
			// tbtnPasteData
			// 
			this.tbtnPasteData.Image = ((System.Drawing.Image)(resources.GetObject("tbtnPasteData.Image")));
			this.tbtnPasteData.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtnPasteData.Name = "tbtnPasteData";
			this.tbtnPasteData.Size = new System.Drawing.Size(52, 22);
			this.tbtnPasteData.Text = "粘贴";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
			this.toolStripLabel1.Text = "列分隔符：";
			// 
			// txtColumnSpliter
			// 
			this.txtColumnSpliter.Name = "txtColumnSpliter";
			this.txtColumnSpliter.Size = new System.Drawing.Size(100, 25);
			// 
			// tbtnConvertDategrid
			// 
			this.tbtnConvertDategrid.Image = ((System.Drawing.Image)(resources.GetObject("tbtnConvertDategrid.Image")));
			this.tbtnConvertDategrid.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtnConvertDategrid.Name = "tbtnConvertDategrid";
			this.tbtnConvertDategrid.Size = new System.Drawing.Size(52, 22);
			this.tbtnConvertDategrid.Text = "转换";
			this.tbtnConvertDategrid.Click += new System.EventHandler(this.TbtnConvertDategridClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtScript);
			this.tabPage2.Controls.Add(this.panelPaddingScript);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(543, 266);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "模板代码";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtScript
			// 
			this.txtScript.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtScript.Location = new System.Drawing.Point(3, 80);
			this.txtScript.Name = "txtScript";
			this.txtScript.Size = new System.Drawing.Size(537, 183);
			this.txtScript.TabIndex = 1;
			this.txtScript.Text = "";
			// 
			// panelPaddingScript
			// 
			this.panelPaddingScript.Controls.Add(this.toolStripFileGenerate);
			this.panelPaddingScript.Controls.Add(this.toolStripCodeSnippet);
			this.panelPaddingScript.Controls.Add(this.toolStripTemplate);
			this.panelPaddingScript.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelPaddingScript.Location = new System.Drawing.Point(3, 3);
			this.panelPaddingScript.Name = "panelPaddingScript";
			this.panelPaddingScript.Size = new System.Drawing.Size(537, 77);
			this.panelPaddingScript.TabIndex = 0;
			// 
			// toolStripFileGenerate
			// 
			this.toolStripFileGenerate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripLabel6,
									this.toolStripSeparator7,
									this.toolStripLabel7,
									this.tcmbFilenameTemplate,
									this.toolStripSeparator8,
									this.toolStripLabel8,
									this.tcmbFilePath,
									this.toolStripSeparator9,
									this.tbtnGenerateFile});
			this.toolStripFileGenerate.Location = new System.Drawing.Point(0, 50);
			this.toolStripFileGenerate.Name = "toolStripFileGenerate";
			this.toolStripFileGenerate.Size = new System.Drawing.Size(537, 25);
			this.toolStripFileGenerate.TabIndex = 3;
			this.toolStripFileGenerate.Text = "toolStrip1";
			// 
			// toolStripLabel6
			// 
			this.toolStripLabel6.Name = "toolStripLabel6";
			this.toolStripLabel6.Size = new System.Drawing.Size(56, 22);
			this.toolStripLabel6.Text = "文件生成";
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel7
			// 
			this.toolStripLabel7.Name = "toolStripLabel7";
			this.toolStripLabel7.Size = new System.Drawing.Size(80, 22);
			this.toolStripLabel7.Text = "文件名模板：";
			// 
			// tcmbFilenameTemplate
			// 
			this.tcmbFilenameTemplate.Items.AddRange(new object[] {
									"<%=row[0]%>.js"});
			this.tcmbFilenameTemplate.Name = "tcmbFilenameTemplate";
			this.tcmbFilenameTemplate.Size = new System.Drawing.Size(121, 25);
			this.tcmbFilenameTemplate.Text = "<%=row[0]%>.js";
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel8
			// 
			this.toolStripLabel8.Name = "toolStripLabel8";
			this.toolStripLabel8.Size = new System.Drawing.Size(44, 22);
			this.toolStripLabel8.Text = "路径：";
			// 
			// tcmbFilePath
			// 
			this.tcmbFilePath.Name = "tcmbFilePath";
			this.tcmbFilePath.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
			// 
			// tbtnGenerateFile
			// 
			this.tbtnGenerateFile.Image = ((System.Drawing.Image)(resources.GetObject("tbtnGenerateFile.Image")));
			this.tbtnGenerateFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtnGenerateFile.Name = "tbtnGenerateFile";
			this.tbtnGenerateFile.Size = new System.Drawing.Size(52, 22);
			this.tbtnGenerateFile.Text = "生成";
			this.tbtnGenerateFile.Click += new System.EventHandler(this.TbtnGenerateFileClick);
			// 
			// toolStripCodeSnippet
			// 
			this.toolStripCodeSnippet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripLabel4,
									this.toolStripSeparator5,
									this.toolStripLabel3,
									this.tcmbCodeSnippet});
			this.toolStripCodeSnippet.Location = new System.Drawing.Point(0, 25);
			this.toolStripCodeSnippet.Name = "toolStripCodeSnippet";
			this.toolStripCodeSnippet.Size = new System.Drawing.Size(537, 25);
			this.toolStripCodeSnippet.TabIndex = 1;
			this.toolStripCodeSnippet.Text = "toolStrip5";
			// 
			// toolStripLabel4
			// 
			this.toolStripLabel4.Name = "toolStripLabel4";
			this.toolStripLabel4.Size = new System.Drawing.Size(44, 22);
			this.toolStripLabel4.Text = "编辑器";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(68, 22);
			this.toolStripLabel3.Text = "代码片段：";
			// 
			// tcmbCodeSnippet
			// 
			this.tcmbCodeSnippet.Items.AddRange(new object[] {
									"<%=row[0]%>"});
			this.tcmbCodeSnippet.Name = "tcmbCodeSnippet";
			this.tcmbCodeSnippet.Size = new System.Drawing.Size(121, 25);
			this.tcmbCodeSnippet.SelectedIndexChanged += new System.EventHandler(this.TcmbCodeSnippetSelectedIndexChanged);
			// 
			// toolStripTemplate
			// 
			this.toolStripTemplate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripLabel5,
									this.toolStripSeparator6,
									this.toolStripLabel2,
									this.tcmbScript,
									this.toolStripSeparator1,
									this.tbtnScriptRun,
									this.toolStripSeparator3,
									this.tbtnScriptSave,
									this.tbtnScriptDelete,
									this.toolStripSeparator4});
			this.toolStripTemplate.Location = new System.Drawing.Point(0, 0);
			this.toolStripTemplate.Name = "toolStripTemplate";
			this.toolStripTemplate.Size = new System.Drawing.Size(537, 25);
			this.toolStripTemplate.TabIndex = 0;
			this.toolStripTemplate.Text = "toolStrip2";
			// 
			// toolStripLabel5
			// 
			this.toolStripLabel5.Name = "toolStripLabel5";
			this.toolStripLabel5.Size = new System.Drawing.Size(56, 22);
			this.toolStripLabel5.Text = "模板管理";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(44, 22);
			this.toolStripLabel2.Text = "模板：";
			// 
			// tcmbScript
			// 
			this.tcmbScript.AutoSize = false;
			this.tcmbScript.Name = "tcmbScript";
			this.tcmbScript.Size = new System.Drawing.Size(220, 25);
			this.tcmbScript.SelectedIndexChanged += new System.EventHandler(this.TcmbScriptSelectedIndexChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tbtnScriptRun
			// 
			this.tbtnScriptRun.Image = ((System.Drawing.Image)(resources.GetObject("tbtnScriptRun.Image")));
			this.tbtnScriptRun.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtnScriptRun.Name = "tbtnScriptRun";
			this.tbtnScriptRun.Size = new System.Drawing.Size(52, 22);
			this.tbtnScriptRun.Text = "运行";
			this.tbtnScriptRun.Click += new System.EventHandler(this.TbtnScriptRunClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// tbtnScriptSave
			// 
			this.tbtnScriptSave.Image = ((System.Drawing.Image)(resources.GetObject("tbtnScriptSave.Image")));
			this.tbtnScriptSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtnScriptSave.Name = "tbtnScriptSave";
			this.tbtnScriptSave.Size = new System.Drawing.Size(52, 22);
			this.tbtnScriptSave.Text = "保存";
			this.tbtnScriptSave.Click += new System.EventHandler(this.TbtnScriptSaveClick);
			// 
			// tbtnScriptDelete
			// 
			this.tbtnScriptDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbtnScriptDelete.Image")));
			this.tbtnScriptDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtnScriptDelete.Name = "tbtnScriptDelete";
			this.tbtnScriptDelete.Size = new System.Drawing.Size(52, 22);
			this.tbtnScriptDelete.Text = "删除";
			this.tbtnScriptDelete.Click += new System.EventHandler(this.TbtnScriptDeleteClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.txtResult);
			this.tabPage3.Controls.Add(this.panelPaddingResult);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(543, 266);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "替换结果";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// txtResult
			// 
			this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtResult.Location = new System.Drawing.Point(3, 32);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtResult.Size = new System.Drawing.Size(537, 231);
			this.txtResult.TabIndex = 1;
			this.txtResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtResultKeyDown);
			// 
			// panelPaddingResult
			// 
			this.panelPaddingResult.Controls.Add(this.toolStripResult);
			this.panelPaddingResult.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelPaddingResult.Location = new System.Drawing.Point(3, 3);
			this.panelPaddingResult.Name = "panelPaddingResult";
			this.panelPaddingResult.Size = new System.Drawing.Size(537, 29);
			this.panelPaddingResult.TabIndex = 0;
			// 
			// toolStripResult
			// 
			this.toolStripResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tbtnCopyResult});
			this.toolStripResult.Location = new System.Drawing.Point(0, 0);
			this.toolStripResult.Name = "toolStripResult";
			this.toolStripResult.Size = new System.Drawing.Size(537, 25);
			this.toolStripResult.TabIndex = 0;
			this.toolStripResult.Text = "toolStrip3";
			// 
			// tbtnCopyResult
			// 
			this.tbtnCopyResult.Image = ((System.Drawing.Image)(resources.GetObject("tbtnCopyResult.Image")));
			this.tbtnCopyResult.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtnCopyResult.Name = "tbtnCopyResult";
			this.tbtnCopyResult.Size = new System.Drawing.Size(52, 22);
			this.tbtnCopyResult.Text = "复制";
			this.tbtnCopyResult.Click += new System.EventHandler(this.TbtnCopyResultClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 339);
			this.Controls.Add(this.panelData);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStripMain);
			this.Name = "MainForm";
			this.Text = "CodeTemplater";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.panelData.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panelDataAndGrid.ResumeLayout(false);
			this.panelDataAndGrid.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panelPaddingData.ResumeLayout(false);
			this.panelPaddingData.PerformLayout();
			this.toolStripData.ResumeLayout(false);
			this.toolStripData.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.panelPaddingScript.ResumeLayout(false);
			this.panelPaddingScript.PerformLayout();
			this.toolStripFileGenerate.ResumeLayout(false);
			this.toolStripFileGenerate.PerformLayout();
			this.toolStripCodeSnippet.ResumeLayout(false);
			this.toolStripCodeSnippet.PerformLayout();
			this.toolStripTemplate.ResumeLayout(false);
			this.toolStripTemplate.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.panelPaddingResult.ResumeLayout(false);
			this.panelPaddingResult.PerformLayout();
			this.toolStripResult.ResumeLayout(false);
			this.toolStripResult.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripComboBox tcmbFilePath;
		private System.Windows.Forms.ToolStripLabel toolStripLabel8;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripLabel toolStripLabel5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripLabel toolStripLabel4;
		private System.Windows.Forms.ToolStripButton tbtnGenerateFile;
		private System.Windows.Forms.ToolStripComboBox tcmbFilenameTemplate;
		private System.Windows.Forms.ToolStripLabel toolStripLabel7;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripLabel toolStripLabel6;
		private System.Windows.Forms.ToolStrip toolStripFileGenerate;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton tbtnConvertDategrid;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripComboBox tcmbCodeSnippet;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStrip toolStripCodeSnippet;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tbtnScriptRun;
		private System.Windows.Forms.ToolStripButton tbtnScriptDelete;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tbtnPasteData;
		private System.Windows.Forms.ToolStrip toolStripData;
		private System.Windows.Forms.ToolStripButton tbtnCopyResult;
		private System.Windows.Forms.ToolStrip toolStripResult;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tbtnScriptSave;
		private System.Windows.Forms.ToolStripComboBox tcmbScript;
		private System.Windows.Forms.ToolStrip toolStripTemplate;
		private System.Windows.Forms.Panel panelPaddingScript;
		private System.Windows.Forms.Panel panelPaddingResult;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.RichTextBox txtScript;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ToolStripTextBox txtColumnSpliter;
		private System.Windows.Forms.Panel panelDataAndGrid;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Panel panelData;
		private System.Windows.Forms.ToolStripButton tbtnRunTemplate;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStrip toolStripMain;
		private System.Windows.Forms.Panel panelPaddingData;

	}
}
