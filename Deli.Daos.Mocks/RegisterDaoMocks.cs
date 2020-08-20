using MetaShare.Common.Core.Daos;
using Deli.Daos.Interfaces.Package01;
using Deli.Daos.Mocks.Package01;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Daos.Mocks
{
	public class RegisterDaoMocks
	{
		public static void RegisterAll()
		{
			Register(DaoFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(DaoFactory.Instance, false);
		}

		public static void Register(DaoFactory factory, bool isRegister)
		{
			factory.Register(typeof(ImljDao), new mljDaoMock(), isRegister);
			factory.Register(typeof(IlpoiDao), new lpoiDaoMock(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
