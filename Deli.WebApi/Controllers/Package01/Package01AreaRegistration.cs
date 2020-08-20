using System.Web.Http;
using System.Web.Mvc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.WebApi.Controllers.Package01
{
	public class Package01AreaRegistration:AreaRegistration
	{
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.Routes.MapHttpRoute(
			name:"Package01",
			routeTemplate:"Package01/{controller}/{action}/{id}",
			defaults:new 
			{
				area = "Package01",
				action = "Index",
				id = UrlParameter.Optional,
				namespaceName = new[] {"Deli.WebApi.Controllers.Package01"}
			});
		}

		public override string AreaName
		{
			get { return "Package01"; }
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
