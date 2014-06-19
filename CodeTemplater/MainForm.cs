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
using System.Linq;
using Efreda.Script;
using SqliteORM;
using System.Reflection;
using CodeTemplater.Model;

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
			
			initDatabase();
			
			initScriptCombo();
			
		}
		
		protected void initDatabase()
		{
			string connectString = @"Data Source=appdata.db3;Pooling=true;FailIfMissing=false";
			DbConnection.Initialise( connectString, Assembly.GetExecutingAssembly() );
			_conn = new DbConnection();
			
		}
		
		protected void initScriptCombo()
		{
			_dictScriptId = new Dictionary<string, long>();
			using (TableAdapter<CodeTemplater.Model.Script> adapter =
			       TableAdapter<CodeTemplater.Model.Script>.Open())
			{
				foreach (CodeTemplater.Model.Script item in adapter.Select()) {
					tcmbScript.Items.Add( item.title );
					_dictScriptId[item.title] = item.id;
				}
			}
		}
		
		
		/// <summary>
		/// 转换文本数据
		/// </summary>
		/// <param name="data"></param>
		/// <param name="colSep"></param>
		/// <returns></returns>
		protected List<List<string>> _parseData(string data, string colSep)
		{
			data = data.Replace("\r", "");
			string[] lines = data.Split('\n');
			List<List<string>> ret = new List<List<string>>();
			foreach (string line in lines) {
				string[] cols = line.Split(new string[]{colSep}, StringSplitOptions.None);
				ret.Add(cols.ToList());
			}
			return ret;
		}
		
		protected string _runTemplate(List<List<string>> data, string script)
		{
			JScriptManager.AddGlobalInstance("dataContainer", new DataContainer(data));
			object ret = JScriptManager.run(script);
			if (ret == null)
				return "";
			else
				return ret.ToString();
		}
		
		void TbtnRunTemplateClick(object sender, EventArgs e)
		{
			string dataStr = txtData.Text;
			string colSep = txtColumnSpliter.Text;
			string scripts = txtScript.Text;
			
			List<List<string>> rows = _parseData(dataStr, colSep);
			txtResult.Text = _runTemplate(rows, scripts);
			try {
				
			} catch (Exception ex) 
			{
				MessageBox.Show(ex.StackTrace, ex.Message);
			}
			
			
		}
		
		void TbtnScriptSaveClick(object sender, System.EventArgs e)
		{
			CodeTemplater.Model.Script item = new CodeTemplater.Model.Script();
			item.title = tcmbScript.Text;
			item.content = txtScript.Rtf;
			item.Save();
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
	}
}
