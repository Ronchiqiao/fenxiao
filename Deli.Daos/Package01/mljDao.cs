using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using Deli.Daos.Interfaces.Package01;
using Deli.Entities.Package01;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Daos.Package01
{
	public class mljDao : CommonObjectDao<mlj>, ImljDao
	{
		public class mljSqlBuilder : ObjectSqlBuilder
		{
			public mljSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"mlj")
			{
				this.SqlInsert = "INSERT INTO mlj (mkl," + this.SqlBaseFieldInsertFront + ") VALUES (@mkl," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE mlj SET mkl=@mkl," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class mljResultHandler : CommonObjectResultHandler<mlj>
		{
			public override void GetColumnValues(IDataReader reader, mlj item)
			{
				base.GetColumnValues(reader, item);
				int ordinalmkl = reader.GetOrdinal("mkl");
				item.mkl = reader.IsDBNull(ordinalmkl) ? null : reader.GetString(ordinalmkl);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, mlj item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "mkl", item.mkl ?? (object) DBNull.Value);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public mljDao(SqlDialect sqlDialect) : base(new mljSqlBuilder(sqlDialect), new mljResultHandler())
		{
		}

		public mljDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new mljSqlBuilder(sqlDialect), new mljResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
