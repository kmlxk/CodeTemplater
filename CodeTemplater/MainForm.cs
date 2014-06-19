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
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			initDatabase();
		}
		
		protected void initDatabase()
		{
			string connectString = @"Data Source=appdata.db3;Pooling=true;FailIfMissing=false";
			DbConnection.Initialise( connectString, Assembly.GetExecutingAssembly() );
			_conn = new DbConnection();
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
			object ret = JScriptManager.run(script);
			return ret.ToString();
		}
		
		void TbtnRunTemplateClick(object sender, EventArgs e)
		{
			string dataStr = txtData.Text;
			string colSep = txtColumnSpliter.Text;
			string scripts = txtScript.Text;
			
			List<List<string>> rows = _parseData(dataStr, colSep);
			
			txtResult.Text = _runTemplate(rows, scripts);
			
		}
				
		void TbtnScriptSaveClick(object sender, System.EventArgs e)
		{
			Script item = new Script();
			item.title = tcmbScript.Text;
			item.content = txtScript.Text;
			item.Save();
		}
	}
}
