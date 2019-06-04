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
            //
            //What are AXD files?  Is this a way to suppress hacks?   ----6/4/2019 td 
            //
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //
            //Added 6/4/2019 thomas downes
            //
            routes.MapRoute(
                name: "PersonalityCfgAndRecip",
                url: "CfgRecipient/{personalitycfg_id}/{recipient_id}",
                defaults: new { controller = "CfgRecipient", action = "Index", personalitycfg_id = 1, recipient_id = "A999" }, 
                constraints: new { personalitycfg_id = @"/d{1}"}
            );

            //
            //Added 5/28/2019 thomas downes
            //
            //   http://www.leftycoder.com/routing-file-requests-to-an-asp-net-mvc-route/
            //
            routes.MapRoute(name: "LegacyHtml_NotTested",
                            url: "{page}.htm",
                            defaults: new { controller = "LegacyPages", action = "Index", page = UrlParameter.Optional });

            //
            //Added 5/28/2019 thomas downes
            //
            //   http://www.leftycoder.com/routing-file-requests-to-an-asp-net-mvc-route/
            //
            routes.MapRoute(name: "LegacyAspx_MightNotWork",
                            url: "{page}.aspx",
                            defaults: new { controller = "LegacyPages", action = "Index", page = UrlParameter.Optional });

            //
            //Standard MVC Scaffolding
            //
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{parameter_id}",
                defaults: new { controller = "Home", action = "Index", parameter_id = UrlParameter.Optional }
            );
        }
    }
}
