/*
 *  Sqlite ORM - PUBLIC DOMAIN LICENSE
 *  Copyright (C)  2010-2012. Ian Quigley
 *
 *  This source code is provided 'As is'. You bear the risk of using it.
 */

using System;
using SqliteORM;

namespace CodeTemplater.Model
{
	[Table]
	public class Script : TableBase<SimpleTable>
	{
		[PrimaryKey]
		public long id { get; set; }

		[Field]
		public string title { get; set; }
		
		[Field]
		public string content { get; set; }
		
		[Field]
		public DateTime created { get; set; }
		
		[Field]
		public DateTime updated { get; set; }
	}
}