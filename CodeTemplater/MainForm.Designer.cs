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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tbtnRunTemplate = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtData = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolStrip4 = new System.Windows.Forms.ToolStrip();
			this.tbtnPasteData = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txtColumnSpliter = new System.Windows.Forms.ToolStripTextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtScript = new System.Windows.Forms.RichTextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.tcmbScript = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tbtnScriptSave = new System.Windows.Forms.ToolStripButton();
			this.tbtnScriptDelete = new System.Windows.Forms.ToolStripButton();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.toolStrip3 = new System.Windows.Forms.ToolStrip();
			this.tbtnCopyResult = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.toolStrip4.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.toolStrip3.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tbtnRunTemplate});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(551, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
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
			this.statusStrip1.Location = new System.Drawing.Point(0, 378);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(551, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tabControl1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 25);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(551, 353);
			this.panel2.TabIndex = 4;
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
			this.tabControl1.Size = new System.Drawing.Size(551, 353);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel3);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(543, 327);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "数据";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txtData);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 30);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(537, 294);
			this.panel3.TabIndex = 1;
			// 
			// txtData
			// 
			this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtData.Location = new System.Drawing.Point(0, 0);
			this.txtData.Multiline = true;
			this.txtData.Name = "txtData";
			this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtData.Size = new System.Drawing.Size(537, 294);
			this.txtData.TabIndex = 0;
			this.txtData.Text = "id\tID\r\nuseragent\t浏览器\r\nip\tIP\r\nmodule\t模块\r\ndata\t数据\r\ncreated\t创建日期\r\nupdated\t修改日期";
			this.txtData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDataKeyDown);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.toolStrip4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(537, 27);
			this.panel1.TabIndex = 0;
			// 
			// toolStrip4
			// 
			this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tbtnPasteData,
									this.toolStripSeparator2,
									this.toolStripLabel1,
									this.txtColumnSpliter});
			this.toolStrip4.Location = new System.Drawing.Point(0, 0);
			this.toolStrip4.Name = "toolStrip4";
			this.toolStrip4.Size = new System.Drawing.Size(537, 25);
			this.toolStrip4.TabIndex = 2;
			this.toolStrip4.Text = "toolStrip4";
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
			this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
			this.toolStripLabel1.Text = "列分隔符";
			// 
			// txtColumnSpliter
			// 
			this.txtColumnSpliter.Name = "txtColumnSpliter";
			this.txtColumnSpliter.Size = new System.Drawing.Size(100, 25);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtScript);
			this.tabPage2.Controls.Add(this.panel5);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(543, 327);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "模板代码";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtScript
			// 
			this.txtScript.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtScript.Location = new System.Drawing.Point(3, 32);
			this.txtScript.Name = "txtScript";
			this.txtScript.Size = new System.Drawing.Size(537, 292);
			this.txtScript.TabIndex = 1;
			this.txtScript.Text = "";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.toolStrip2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(3, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(537, 29);
			this.panel5.TabIndex = 0;
			// 
			// toolStrip2
			// 
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripLabel2,
									this.tcmbScript,
									this.toolStripSeparator1,
									this.tbtnScriptSave,
									this.tbtnScriptDelete});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(537, 25);
			this.toolStrip2.TabIndex = 0;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
			this.toolStripLabel2.Text = "模板";
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
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.txtResult);
			this.tabPage3.Controls.Add(this.panel4);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(543, 327);
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
			this.txtResult.Size = new System.Drawing.Size(537, 292);
			this.txtResult.TabIndex = 1;
			this.txtResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtResultKeyDown);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.toolStrip3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(537, 29);
			this.panel4.TabIndex = 0;
			// 
			// toolStrip3
			// 
			this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tbtnCopyResult});
			this.toolStrip3.Location = new System.Drawing.Point(0, 0);
			this.toolStrip3.Name = "toolStrip3";
			this.toolStrip3.Size = new System.Drawing.Size(537, 25);
			this.toolStrip3.TabIndex = 0;
			this.toolStrip3.Text = "toolStrip3";
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
			this.ClientSize = new System.Drawing.Size(551, 400);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "CodeTemplater";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.toolStrip4.ResumeLayout(false);
			this.toolStrip4.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.toolStrip3.ResumeLayout(false);
			this.toolStrip3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton tbtnScriptDelete;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tbtnPasteData;
		private System.Windows.Forms.ToolStrip toolStrip4;
		private System.Windows.Forms.ToolStripButton tbtnCopyResult;
		private System.Windows.Forms.ToolStrip toolStrip3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tbtnScriptSave;
		private System.Windows.Forms.ToolStripComboBox tcmbScript;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.RichTextBox txtScript;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ToolStripTextBox txtColumnSpliter;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStripButton tbtnRunTemplate;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Panel panel1;

	}
}
