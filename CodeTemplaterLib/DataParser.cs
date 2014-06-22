/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014/6/20
 * 时间: 21:47
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeTemplaterLib
{
	/// <summary>
	/// Description of DataParser.
	/// </summary>
	public class DataParser
	{
		public DataParser()
		{
		}
		
		
		/// <summary>
		/// 转换文本数据
		/// </summary>
		/// <param name="data"></param>
		/// <param name="colSep"></param>
		/// <returns></returns>
		public static string[][] parseCvs(string data, string colSep)
		{
			// 默认列分隔符
			if (colSep == null || colSep.Length == 0) {
				colSep = "\t";
			}
			data = data.Replace("\r", "");
			string[] lines = data.Split('\n');
			string[][] retArray = new string[lines.Length][];
			int i = 0;
			foreach (string line in lines) {
				string[] cols = line.Split(new string[]{colSep}, StringSplitOptions.None);
				retArray[i] = cols;
				i++;
			}
			return retArray;
		}
		
		
	}
}
