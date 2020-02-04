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
            ClassElementsCache_Deprecated obj_cache;
            //obj_cache = new ClassElementsCache();
            //obj_cache.LoadFieldElements();

            string path_toElementsCacheXML;
            int intSection = 0; //Added 11/27/2019 td

            //Added 11/16/2019 Thomas DOWNES  
            //11/27/2019 td//path_toElementsCacheXML = ConfigurationManager.AppSettings["pathToElementsCacheXML"];
            path_toElementsCacheXML = ciBadgeForWeb.App_Start.DiskFiles.PathToFile_XML_Current(true);

            //Added 11/16/2019 Thomas DOWNES  
            //11/27 td//bool boolNewFile = System.IO.File.Exists(path_toElementsCacheXML);
            bool boolNewFile = (! (System.IO.File.Exists(path_toElementsCacheXML)));
            FormBadgeLayoutProto obj_form = new FormBadgeLayoutProto();

            //Added 11/16/2019 Thomas DOWNES  
            try
            {
                ClassElementsCache_Deprecated.Singleton =
                    ClassElementsCache_Deprecated.GetLoadedCache(path_toElementsCacheXML,
                    boolNewFile, obj_form.pictureBack.Image, ref intSection);
            }
            catch (Exception ex_Global_App_Start)
            {
                //Added 11/27/2019 td 
                throw new Exception("Obviously, this is undesirable.  Section: " + 
                    intSection.ToString(), ex_Global_App_Start);
            }

        }

    }
}
