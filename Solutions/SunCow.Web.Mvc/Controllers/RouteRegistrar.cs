namespace SunCow.Web.Mvc.Controllers
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteRegistrar
    {
        public static void RegisterRoutesTo(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });

			routes.MapRoute(
				"Custom Card Details",
				"Custom/{category}/{cardId}",
				new { controller = "Custom", action = "Details" });

			routes.MapRoute(
				"Custom Cards",
				"Custom/{category}",
				new { controller = "Custom", action = "Category" });

			routes.MapRoute(
				"Card Details",
				"Cards/{category}/{cardName}",
				new { controller = "Card", action = "Details" });

			routes.MapRoute(
				"Cards",
				"Cards/{category}",
				new { controller = "Card", action = "Category" });

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Card", action = "Index", id = UrlParameter.Optional }); // Parameter defaults
        }
    }
}
