using MetaShare.Common.Core.DataSchema;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Daos.DataSchema.Package01
{
	public class lpoiDdlBuilder : DdlBuilder
	{
		public override string GetSqlCreateTable()
		{
			return @"CREATE TABLE lpoi(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,Description nvarchar(255),klj nvarchar(255),Name nvarchar(255),Description nvarchar(255),Owner_Id int,Entity_Status int)";
		}

		public override string GetSqlDropTable()
		{
			return @"DROP TABLE lpoi";
		}

		public override string GetSqlExistTable()
		{
			return @"SELECT COUNT(*) FROM Information_Schema.COLUMNS WHERE TABLE_NAME = 'lpoi'";
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
