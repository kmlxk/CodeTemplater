/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014/6/20
 * 时间: 21:52
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace CodeTemplaterLib.UnitTest
{
	[TestFixture]
	public class TemplateParserTest
	{
		
		string _template = @"{ name: '<%=row[0]%>', mapping: '<%=row[0]%>',  type: 'auto' },
";
		string _datastr =@"
id	ID
useragent	浏览器
ip	IP
module	模块
data	数据
created	创建日期
updated	修改日期
";
		
		[Test]
		public void TestRegex()
		{
			Regex re = new Regex("<%=(.*?)%>", RegexOptions.Singleline);
			MatchCollection mc = re.Matches(_template);
			foreach (Match m in mc ) {
				Console.WriteLine(m.Groups[1]);
			}
		}
		
		[Test]
		public void TestRun()
		{
			string[][] data = DataParser.parseCvs(_datastr, "\t");
			string ret = TemplateParser.run(data, _template);
			Console.WriteLine(ret);
		}
	}
}
