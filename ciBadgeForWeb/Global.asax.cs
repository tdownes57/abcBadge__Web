using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ciBadgeElements; //Added 11/15/2019 thomas downes  
using System.Windows.Forms;  //Added 11/16/2019 td 
using System.Configuration;

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

            //Added 11/16/2019 Thomas DOWNES  
            path_toElementsCacheXML = ConfigurationManager.AppSettings["pathToElementsCacheXML"];

            //Added 11/16/2019 Thomas DOWNES  
            bool boolNewFile = System.IO.File.Exists(path_toElementsCacheXML);
            FormBadgeLayoutProto obj_form = new FormBadgeLayoutProto();

            //Added 11/16/2019 Thomas DOWNES  
            try
            {
                ClassElementsCache.Singleton =
                    ClassElementsCache.GetLoadedCache(path_toElementsCacheXML,
                    boolNewFile, obj_form.pictureBack.Image);
            }
            catch (Exception ex_Global_App_Start)
            {
                //Added 11/27/2019 td 
                throw new Exception("Obviously, this is undesirable.", ex_Global_App_Start);
            }

        }

    }
}
