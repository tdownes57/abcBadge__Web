using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ciBadgeElements; //Added 11/15/2019 thomas downes  

namespace ciBadgeForWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //
            //Added 11//14/2019 thomas downes
            //
            ClassElementsCache obj_cache;
            //obj_cache = new ClassElementsCache();
            //obj_cache.LoadFieldElements();

            string path_toElementsCacheXML;


            obj_cache = ClassElementsCache.GetLoadedCache(path_toElementsCacheXML);


        }

    }
}
