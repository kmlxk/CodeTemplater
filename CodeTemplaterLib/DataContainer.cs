/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014/6/20
 * 时间: 21:50
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;

namespace CodeTemplaterLib
{
	/// <summary>
	/// Description of DataContainer.
	/// </summary>
	public class DataContainer
	{

		protected string[][] _data;
		
		public string[][] Data {
			get { return _data; }
			set { _data = value; }
		}
		
		public DataContainer(string[][] data)
		{
			_data = data;
		}
		
		public string[] this[int index]
		{
			get{
				return Data[index];
			}
		}
		
		public string getAt(int row, int col) {
			return _data[row][col];
		}
		
		public int getRowCount() {
			return _data.Length;
		}
		
		public int getColCount(int row) {
			return _data[row].Length;
		}
		
	}
}
