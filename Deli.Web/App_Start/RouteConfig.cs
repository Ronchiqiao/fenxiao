using System.Web.Mvc;
using System.Web.Routing;/*add customized code between this region*/
/*add customized code between this region*/


namespace Deli.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",defaults: new { controller = "mlj", action = "Index", id = UrlParameter.Optional },
				namespaces:new[]  {"Deli.Web.Controllers.Package01"});
				/*add customized code between this region*/
				/*add customized code between this region*/
				
        }
    }
}