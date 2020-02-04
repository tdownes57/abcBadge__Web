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
            //   For specifying both Personality Configuration and Recipient ID.  
            //      (cis = CI Solutions)  
            //
            //routes.MapRoute(
            //    name: "PersonalityCfgAndRecip",
            //    url: "cis/CfgRecipient/{personalitycfg_id}/{recipient_id}",
            //    defaults: new { controller = "CfgRecipient", action = "Index", personalitycfg_id = 1, recipient_id = "A999" }, 
            //    constraints: new { personalitycfg_id = @"/d{1}"}
            //);

            //
            //Added 6/4/2019 thomas downes
            //
            //   For testing extensive parameters.  
            //
            //routes.MapRoute(
            //    name: "TestingParams",
            //    url: "TestingParams/{param1}/{param2}/{param3}/{param4}",
            //    defaults: new { controller = "TestingParams", action = "Index", p1 = "ABC100", p2 = "A999", p3 = "zzz", p4 = 99 },
            //    constraints: new { p4 = @"/d{2}" }
            //);

            //
            // cis = CI Solutions
            //
            //routes.MapRoute(
            //    name: "Steps1and2_Search_CIS",
            //    url: "cis/Steps1and2/ShowSearchResults/{par_lastname}",
            //    defaults: new { controller = "Steps1and2", action = "ShowSearchResults", par_lastname="Forbes" }
            //);

            //
            // Added 7/3/2019 thomas DOWNES
            //
            routes.MapRoute(
               name: "UploadBack",
                    url: "UploadBack",
                    defaults: new { controller = "UploadBack", action = "Index" }
                );

            //
            // Added 7/7/2019 thomas DOWNES
            //
            routes.MapRoute(
                name: "Backgrounds",
                url: "Backgrounds",
                defaults: new { controller = "UploadBack", action = "ShowAll" }
            );

            //
            // tcd = Thomas C. Downes
            //
            //routes.MapRoute(
            //    name: "Steps1and2_Search_TCD",
            //    url: "tcd/Steps1and2/ShowSearchResults/{par_lastname}",
            //    defaults: new { controller = "Steps1and2", action = "ShowSearchResults", par_lastname = "Forbes" }
            //);

            //
            //Added 5/28/2019 thomas downes
            //
            //   http://www.leftycoder.com/routing-file-requests-to-an-asp-net-mvc-route/
            //
            //routes.MapRoute(name: "LegacyHtml_NotTested",
            //                url: "{page}.htm",
            //                defaults: new { controller = "LegacyPages", action = "Index", page = UrlParameter.Optional });

            //
            //Added 5/28/2019 thomas downes
            //
            //   http://www.leftycoder.com/routing-file-requests-to-an-asp-net-mvc-route/
            //
            //routes.MapRoute(name: "LegacyAspx_MightNotWork",
            //                url: "{page}.aspx",
            //                defaults: new { controller = "LegacyPages", action = "Index", page = UrlParameter.Optional });

            //
            //CI Solutions, Standard MVC Scaffolding
            //
            routes.MapRoute(
                name: "Default_CIS1_param",
                url: "{controller}/{action}/{parameter_id}",
                defaults: new { controller = "Home", action = "Login", parameter_id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "Default_CIS1_id",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Default_CIS2",
            //    url: "cis/{controller}/{action}/{parameter_id}",
            //    defaults: new { controller = "Home", action = "Login", parameter_id = UrlParameter.Optional }
            //);

            //
            //Thomas C. Downes, Standard MVC Scaffolding
            //
            //routes.MapRoute(
            //    name: "Default_TCD",
            //    url: "tcd/{controller}/{action}/{parameter_id}",
            //    defaults: new { controller = "Home", action = "Login", parameter_id = UrlParameter.Optional }
            //);





        }
    }
}
