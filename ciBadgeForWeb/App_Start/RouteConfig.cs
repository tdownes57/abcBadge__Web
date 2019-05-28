using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ciBadgeForWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //
            //Added 5/28/2019 thomas downes
            //
            //   http://www.leftycoder.com/routing-file-requests-to-an-asp-net-mvc-route/
            //
            routes.MapRoute(name: "LegacyHtml",
                            url: "{page}.htm",
                            defaults: new { controller = "LegacyPages", action = "Index", page = UrlParameter.Optional });

            //
            //Added 5/28/2019 thomas downes
            //
            //   http://www.leftycoder.com/routing-file-requests-to-an-asp-net-mvc-route/
            //
            routes.MapRoute(name: "LegacyAspx",
                            url: "{page}.aspx",
                            defaults: new { controller = "LegacyPages", action = "Index", page = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{parameter_id}",
                defaults: new { controller = "Home", action = "Index", parameter_id = UrlParameter.Optional }
            );
        }
    }
}
