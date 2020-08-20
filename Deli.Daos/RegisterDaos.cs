using System;
using MetaShare.Common.Core.Daos;
using Deli.Daos.Interfaces.Package01;
using Deli.Daos.Package01;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Daos
{
	public class RegisterDaos
	{
		public static void RegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, true,sqlDialect,sqlDialectVersion);
		}

		public static void UnRegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, false,sqlDialect,sqlDialectVersion);
		}

		public static void Register(DaoFactory factory, bool isRegister, Type sqlDialect, Type sqlDialectVersion)
		{
			factory.Register(typeof(ImljDao), new mljDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(IlpoiDao), new lpoiDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
