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
            //return new RedirectResult("Home");
            return new RedirectResult("ListAllSavedCaches");
        }


        public ActionResult LoadNextCache()
        {
            //
            //Added 11/28/2019 thomas downes 
            //
            string strPathToNextFileXml = 
                      ciBadgeForWeb.App_Start.DiskFiles.PathToFile_XML_Next(true);

            //
            //Refresh the cache with the next cache.
            // 
            // 11-29-2019 td//ClassElementsCache.GetLoadedCache(strPathToNextFileXml, false)

            int intSection = 0;  //Added 11/29/2019 thomas d. 
            ClassElementsCache_Deprecated.GetLoadedCache(strPathToNextFileXml, 
                false, null, ref intSection );

            return new RedirectResult("Home");
        }

        public ActionResult SaveThisCache()
        {
            //
            //Added 11/28/2019 td
            //
            ClassElementsCache_Deprecated.Singleton.SaveToXML();

            return new EmptyResult();

        }

        public ActionResult SaveToNewName()
        {
            //
            //Added 11/28/2019 td
            //
            ClassElementsCache_Deprecated.Singleton.SaveToXML();
            return new EmptyResult();

        }

        public ActionResult ListAllSavedCaches()  // 11-29-2019 td----SavedCaches()
        {
            //
            //Added 11/28/2019 td
            //
            return (ActionResult)View();

        }

        public ActionResult LoadOneSavedCache(string parameter_id)  // Added 11-29-2019 td 
        {
            //
            //Added 11/29/2019 td
            //
            bool boolBrandNewFile = false; //Added 11/29/2019 thomas d.
            int intSection = 0;  //Added 11/29/2019 thomas d. 

            string strFileTitleXML = (parameter_id + ".xml");

            //ciBadgeForWeb.App_Start.DiskFiles.SpecifyCurrent_XML(parameter_id);
            ciBadgeForWeb.App_Start.DiskFiles.SpecifyCurrent_XML(strFileTitleXML);

            string strPathToNewCurrentXML =
                App_Start.DiskFiles.PathToFile_XML_Current(true);
            
            boolBrandNewFile = false; //False, because the XML file might have
            //  been created a week or even a month ago. 

            //
            //Major call !! 
            //
            ClassElementsCache_Deprecated.Singleton =
            ClassElementsCache_Deprecated.GetLoadedCache(strPathToNewCurrentXML,
                boolBrandNewFile, null, ref intSection);

            return (ActionResult)(new EmptyResult());

        }


    }
}