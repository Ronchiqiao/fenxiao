using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using Deli.Daos.Interfaces.Package01;
using Deli.Entities.Package01;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Daos.Package01
{
	public class lpoiDao : CommonObjectDao<lpoi>, IlpoiDao
	{
		public class lpoiSqlBuilder : ObjectSqlBuilder
		{
			public lpoiSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"lpoi")
			{
				this.SqlInsert = "INSERT INTO lpoi (klj," + this.SqlBaseFieldInsertFront + ") VALUES (@klj," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE lpoi SET klj=@klj," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class lpoiResultHandler : CommonObjectResultHandler<lpoi>
		{
			public override void GetColumnValues(IDataReader reader, lpoi item)
			{
				base.GetColumnValues(reader, item);
				int ordinalklj = reader.GetOrdinal("klj");
				item.klj = reader.IsDBNull(ordinalklj) ? null : reader.GetString(ordinalklj);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, lpoi item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "klj", item.klj ?? (object) DBNull.Value);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public lpoiDao(SqlDialect sqlDialect) : base(new lpoiSqlBuilder(sqlDialect), new lpoiResultHandler())
		{
		}

		public lpoiDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new lpoiSqlBuilder(sqlDialect), new lpoiResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
