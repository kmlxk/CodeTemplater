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
		
		void TbtnRunTemplateClick(object sender, EventArgs e)
		{
			string dataStr = txtData.Text;
			string colSep = txtColumnSpliter.Text;
			string scripts = txtScript.Text;
			
			try {
				
				string[][] rows = DataParser.parseCvs(dataStr, colSep);
				txtResult.Text = TemplateParser.run(rows, scripts);
				tabControl1.SelectedIndex = 2;
			} catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace, ex.Message);
			}
			
			
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
	}
}
