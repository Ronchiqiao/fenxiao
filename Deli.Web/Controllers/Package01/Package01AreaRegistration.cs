using System.Web.Mvc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Web.Controllers.Package01
{
	public class Package01AreaRegistration:AreaRegistration
	{
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.MapRoute(
			"Package01",
			"Package01/{controller}/{action}/{id}",
			new {action = "Index", id = UrlParameter.Optional},
			namespaces:new[]  {"Deli.Web.Controllers.Package01"});
		}

		public override string AreaName
		{
			get { return "Package01"; }
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
