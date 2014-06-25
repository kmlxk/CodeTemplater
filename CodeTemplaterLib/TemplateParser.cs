/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014/6/20
 * 时间: 21:46
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using Efreda.Script;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace CodeTemplaterLib
{
	/// <summary>
	/// Description of TemplateParser.
	/// </summary>
	public class TemplateParser
	{
		protected const string TAG_BEGIN = "<%=";
		protected const string TAG_END = "%>";		
		protected static Regex _reTag = new Regex(TAG_BEGIN+"(.*?)"+TAG_END, RegexOptions.Singleline);
		
		public TemplateParser()
		{
		}
		
		public static string run(string[][] data, string template)
		{
			StringBuilder ret = new StringBuilder();
			foreach (string[] row in data) {
				ret.Append(runRow(row, template));
			}
			return ret.ToString();
		}
		
		public static string runRow(string[] row, string template)
		{
			StringBuilder sb = new StringBuilder();
			List<string> listRow = row.ToList();
			JScriptManager.AddGlobalInstance("row", listRow);
			
			MatchCollection mc = _reTag.Matches(template);
			int lastIndex = 0;
			foreach (Match m in mc ) {
				string script = m.Groups[1].Value;
				object ret = JScriptManager.run(script);
				sb.Append(template.Substring(lastIndex, m.Index - lastIndex));
				sb.Append(ret);
				lastIndex = m.Index + m.Length;
			}
			sb.Append(template.Substring(lastIndex));
			return sb.ToString();
		}
	}
}
