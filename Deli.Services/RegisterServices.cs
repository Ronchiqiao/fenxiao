using MetaShare.Common.Core.CommonService;
using Deli.Services.Interfaces.Package01;
using Deli.Services.Package01;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}

		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(ImljService), new mljService(), isRegister);
			factory.Register(typeof(IlpoiService), new lpoiService(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
