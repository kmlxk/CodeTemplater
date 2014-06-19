/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014/6/19
 * 时间: 16:44
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;

namespace CodeTemplater
{
	/// <summary>
	/// Description of DataContainer.
	/// </summary>
	public class DataContainer
	{
		protected List<List<string>> _data;
		
		public List<List<string>> Data {
			get { return _data; }
			set { _data = value; }
		}
		
		
		
		public DataContainer(List<List<string>> data)
		{
			_data = data;
		}
		
		public string getAt(int row, int col) {
			return _data[row][col];
		}
		
		public int getRowCount() {
			return _data.Count;
		}
		
		public int getColCount(int row) {
			return _data[row].Count;
		}
		
	}
}
