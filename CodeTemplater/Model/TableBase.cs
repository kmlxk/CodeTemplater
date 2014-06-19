/*
 *  Sqlite ORM - PUBLIC DOMAIN LICENSE
 *  Copyright (C)  2010-2012. Ian Quigley
 *  
 *  This source code is provided 'As is'. You bear the risk of using it.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using SqliteORM;

namespace CodeTemplater.Model
{
    [Serializable]
	public abstract class TableBase<T>
	{
		public virtual void Save( )
		{
			using (TableAdapter<T> adapter = TableAdapter<T>.Open())
				adapter.CreateUpdate( this );
		}
		
		public static void Do( Action<TableAdapter<T>> action ) 
		{            
            using (TableAdapter<T> adapter = TableAdapter<T>.Open())
                action( adapter );            
		}

        public static void Delete( params object[] args )
        {
            using (TableAdapter<T> adapter = TableAdapter<T>.Open())
                adapter.Delete( args );
        }

        public static T Read( params object[] args )
        {
            using (TableAdapter<T> adapter = TableAdapter<T>.Open())
                return adapter.Read( args );
        }

        public static TReturn Get<TReturn>( Func<TableAdapter<T>, TReturn> action ) where TReturn : class
		{
            using (TableAdapter<T> adapter = TableAdapter<T>.Open())
                return action( adapter );
		}        
	}
}
