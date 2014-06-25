/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014/6/19
 * 时间: 10:09
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SqliteORM;
using System.Reflection;
using CodeTemplater.Model;
using CodeTemplaterLib;

namespace CodeTemplater
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		protected DbConnection _conn;
		protected Dictionary<string, long> _dictScriptId;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			string path = System.Windows.Forms.Application.StartupPath;
			System.IO.Directory.SetCurrentDirectory(path);
			string dbfilename = path +"\\appdata.db3";
			
			initDatabase(dbfilename);
			initConfigCombos();
			
			initScriptCombo();
			
		}
		
		protected void initDatabase(string dbfilename)
		{
			string connectString = @"Data Source="+dbfilename+";Pooling=true;FailIfMissing=false";
			DbConnection.Initialise( connectString, Assembly.GetExecutingAssembly() );
			_conn = new DbConnection();
			
		}
		
		protected void initScriptCombo()
		{
			_dictScriptId = new Dictionary<string, long>();
			using (TableAdapter<CodeTemplater.Model.Script> adapter =
			       TableAdapter<CodeTemplater.Model.Script>.Open())
			{
				foreach (CodeTemplater.Model.Script item in adapter.Select().OrderBy(t=>t.title)) {
					tcmbScript.Items.Add( item.title );
					_dictScriptId[item.title] = item.id;
				}
			}
		}
		
		protected void initConfigCombos()
		{
			using (TableAdapter<CodeTemplater.Model.Config> adapter =
			       TableAdapter<CodeTemplater.Model.Config>.Open())
			{
				foreach (CodeTemplater.Model.Config item in adapter.Select().Where(t=> t.Type == 1)) {
					if (item.Name.Equals("filepath")) {
						if (item.Value == null)
							continue;
						foreach(string val in item.Value.Split(';')) {
							tcmbFilePath.Items.Add(val);
						}
					} else if (item.Name.Equals("filename_template")) {
						if (item.Value == null)
							continue;
						foreach(string val in item.Value.Split(';')) {
							tcmbFilenameTemplate.Items.Add(val);
						}
					}
				}
			}
		}
		
		protected void runTemplate()
		{
			string dataStr = txtData.Text;
			string colSep = txtColumnSpliter.Text;
			string scripts = txtScript.Text;
			
			try {
				string[][] rows = DataParser.parseCvs(dataStr, colSep);
				txtResult.Text = TemplateParser.run(rows, scripts);
				tabControl1.SelectedIndex = 2;
			} catch (Exception ex) {
				MessageBox.Show(ex.StackTrace, ex.Message);
			}
		}
		
		void TbtnRunTemplateClick(object sender, EventArgs e)
		{
			runTemplate();
		}
		
		void TbtnScriptSaveClick(object sender, System.EventArgs e)
		{
			
			// persistence
			CodeTemplater.Model.Script item = new CodeTemplater.Model.Script();
			item.title = tcmbScript.Text;
			item.content = txtScript.Rtf;
			item.Save();
			
			// reload combo
			tcmbScript.Items.Clear();
			initScriptCombo();
		}
		
		void TcmbScriptSelectedIndexChanged(object sender, EventArgs e)
		{
			string title = (string)tcmbScript.SelectedItem;
			if (!_dictScriptId.ContainsKey(title))
				return;
			long id = _dictScriptId[title];
			CodeTemplater.Model.Script item = CodeTemplater.Model.Script.Read(id);
			if (item == null)
				return;
			txtScript.Rtf = item.content;
		}
		
		void TxtDataKeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
			{
				((TextBox)sender).SelectAll();
			}
		}
		
		void TxtResultKeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
			{
				((TextBox)sender).SelectAll();
			}
		}
		
		void TbtnCopyResultClick(object sender, EventArgs e)
		{
			txtResult.SelectAll();
			txtResult.Copy();
		}
		
		void TbtnScriptDeleteClick(object sender, EventArgs e)
		{
			// get selected row id
			string title = (string)tcmbScript.SelectedItem;
			if (!_dictScriptId.ContainsKey(title))
				return;
			long id = _dictScriptId[title];
			CodeTemplater.Model.Script item = CodeTemplater.Model.Script.Read(id);
			if (item == null)
				return;
			// delete
			CodeTemplater.Model.Script.Delete(item);
			
			// reload combo
			tcmbScript.Items.Clear();
			initScriptCombo();
		}
		
		
		void TcmbCodeSnippetSelectedIndexChanged(object sender, System.EventArgs e)
		{
			object item = tcmbCodeSnippet.SelectedItem;
			if (item == null)
				return;
			txtScript.SelectedText = item.ToString();
		}
		
		public void fillDataGridView(DataGridView datagrid, string[][] rows)
		{
			int maxCol = 0;
			foreach (string[] row in rows) {
				if (maxCol < row.Length) {
					maxCol = row.Length;
				}
			}
			for (int i = 0; i < maxCol; i++) {
				string colName = "row["+i+"]";
				datagrid.Columns.Add(colName, colName);
			}
			foreach (string[] row in rows) {
				int rowId = datagrid.Rows.Add();
				for (int i = 0; i < row.Length; i++) {
					datagrid.Rows[rowId].Cells[i].Value = row[i];
				}
			}
		}
		
		void TbtnConvertDategridClick(object sender, EventArgs e)
		{
			string dataStr = txtData.Text;
			string colSep = txtColumnSpliter.Text;
			
			string[][] rows = DataParser.parseCvs(dataStr, colSep);
			
			dataGridView1.Rows.Clear();
			dataGridView1.Columns.Clear();
			
			fillDataGridView(dataGridView1, rows);
		}
		
		void TbtnScriptRunClick(object sender, EventArgs e)
		{
			runTemplate();
		}
		
		void TbtnGenerateFileClick(object sender, EventArgs e)
		{
			string filenameTemplate = tcmbFilenameTemplate.Text;
			string dataStr = txtData.Text;
			string colSep = txtColumnSpliter.Text;
			string scripts = txtScript.Text;
			string filepath = tcmbFilePath.Text;
			string content;
			string filename;
			
			// 保存路径和文件名模板
			if (!tcmbFilePath.Items.Contains(filepath)) {
				tcmbFilePath.Items.Add(filepath);
			}
			if (!tcmbFilenameTemplate.Items.Contains(filenameTemplate)) {
				tcmbFilenameTemplate.Items.Add(filenameTemplate);
			}
			
			// 生成多文件
			if (filepath.Length > 0 && filepath[filepath.Length - 1] != '\\')
				filepath += '\\';
			try {
				string[][] rows = DataParser.parseCvs(dataStr, colSep);
				foreach (string[] row in rows) {
					content = TemplateParser.runRow(row, scripts);
					filename = TemplateParser.runRow(row, filenameTemplate);
					CommonLang.TextFileHelper.writeAll(filepath + filename, content, System.Text.Encoding.UTF8);
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.StackTrace, ex.Message);
			}
		}
		
		protected string getToolStripComboValues(ToolStripComboBox tcmb)
		{
			string[] items = new String[tcmb.Items.Count];
			for (int i = 0; i < tcmb.Items.Count; i++) {
				items[i] = (string)tcmb.Items[i];
			}
			return CommonLang.ArrayHelper<string>.join(items, ";");
		}
		
		protected void saveConfigCombos()
		{
			string filepaths = getToolStripComboValues(tcmbFilePath);
			string filenameTemplates = getToolStripComboValues(tcmbFilenameTemplate);
			
			using (TableAdapter<CodeTemplater.Model.Config> adapter =
			       TableAdapter<CodeTemplater.Model.Config>.Open())
			{
				foreach (CodeTemplater.Model.Config item in adapter.Select().Where(t=> t.Type == 1)) {
					if (item.Name.Equals("filepath")) {
						item.Value = filepaths;
						item.Save();
					} else if (item.Name.Equals("filename_template")) {
						item.Value = filenameTemplates;
						item.Save();
					}
				}
			}
			
			
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			saveConfigCombos();
		}
	}
}
