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
	public class SimpleTable : TableBase<SimpleTable>
	{
		[PrimaryKey]
		public long Id { get; set; }

		[Field]
		public string Test { get; set; }

		[Field]
		public DateTime When { get; set; }
	}
}