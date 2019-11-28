using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeElements; //Added 11/28/2019 thomas downes

namespace ciBadgeForWeb.Controllers
{
    public class XmlCacheController : Controller
    {
        // GET: XmlCache
        public ActionResult Index()
        {
            //return View();
            return new RedirectResult("Home");
        }


        public ActionResult LoadNextCache()
        {
            //
            //Added 11/28/2019 thomas downes 
            //
            string strPathToNextFileXml = 
            ciBadgeForWeb.App_Start.DiskFiles.PathToFile_XML_Next();
            
            //Refresh the cache with the next cache. 
            ClassElementsCache.GetLoadedCache(strPathToNextFileXml, );

            return new RedirectResult("Home");
        }

        public ActionResult SaveThisCache()
        {
            //
            //Added 11/28/2019 td
            //
            ClassElementsCache.Singleton.SaveToXML();
        }

        public ActionResult SaveToNewName()
        {
            //
            //Added 11/28/2019 td
            //

        }

    }
}