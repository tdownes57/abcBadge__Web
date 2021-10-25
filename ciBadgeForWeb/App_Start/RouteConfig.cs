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
            //  No, it's probably a way to _allow_ the MVC system to display
            //  non-MVC-typical files.  In other words, we are telling the MVC
            //  system to "relax" & let old-school webpages to operate as 
            //  non-MVC engineers originally intended them to work.
            //  ----4/1/2020 thomas downes  
            //
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*************************************************************************** 
             * Host Static HTML or WebForms Page within MVC Site
             * 
             * For this to work you need to tell MVC to ignore the route if it's for 
             * the HTML page (or ASPX page in the case of mixing WebForms and MVC). 
             * Find your routing configuration section (for MVC4 it’s in RouteConfig.cs 
             * under the App_Start folder, for MVC1,2,3 it’s in Global.asax). Once found 
             * use the IgnoreRoute() method to tell Routing to ignore the specific paths. 
             * I used this:
             *      routes.IgnoreRoute("hello.htm"); //ignore the specific HTML start page
             *      routes.IgnoreRoute(""); //to ignore any default root requests
             *      
             * Now MVC ignores a request to load the hello HTML page and leaves IIS to 
             * handle returning the resource and hence the page displays correctly.
             * 
            // https://richhewlett.com/2013/11/10/host-static-html-or-webforms-page-within-mvc-site/
             * *************************************************************************/
            //
            // https://richhewlett.com/2013/11/10/host-static-html-or-webforms-page-within-mvc-site/
            // 
            //routes.IgnoreRoute("OrangeCoast/{*pathInfo}");

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
            // Added 2/20/2020 thomas DOWNES
            //
            //routes.MapRoute(
            //    name: "Fields",
            //    url: "Fields",
            //    defaults: new { controller = "Fields", action = "Simple" }
            //);

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
