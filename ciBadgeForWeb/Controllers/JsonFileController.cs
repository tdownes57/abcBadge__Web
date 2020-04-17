using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeForWeb.Models;  // Added 3/21/2020 Thomas Downes 
using ciBadgeElements;  // Added 4/6/2020 Thomas Downes   
//
//     // See also, the CIBadgeElements Project, for JSON- & DIVs- related code. 
//     //   ---Actually, I wasn't able to find it, so maybe I didn't do it.
//     //   ---  So, see Models/ElementDivs.cs.  -----4/2/2020 thomas d. 
//

namespace ciBadgeForWeb.Controllers
{
    public class JsonFileController : Controller
    {
        //
        //     // See also, the CIBadgeElements Project, for JSON- & DIVs- related code. 
        //     //   ---Actually, I wasn't able to find it, so maybe I didn't do it.
        //     //   ---  So, see Models/ElementDivs.cs.  -----4/2/2020 thomas d. 
        //
        //Added 3/21/2020 Thomas Downes
        public static JsonFile JsonFile_MoveableDivs = new JsonFile();
        //Added 4/16/2020 Thomas Downes
        public static MoveableDivImage MoveableDivs;  //--- = new JsonFile();

        // GET: JsonFile
        public ActionResult Index()
        {
            //
            // Added 3/21/2020 Thomas Downes  
            //
            //JsonFile objectJsonFile = new JsonFile();
            var objectJsonFile = JsonFileController.JsonFile_MoveableDivs;

            //return View(objectJsonFile);
            //return IndexGroupWidth();

            //---   4/13/2020  ---//return View(objectJsonFile);
            //---   4/16/2020  ---//var objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);

            //Added 4/16/2020 thomas downes 
            MoveableDivImage objectMoveableDivs = JsonFileController.MoveableDivs; 
            if (JsonFileController.MoveableDivs == null)
            {
                objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);
                JsonFileController.MoveableDivs = objectMoveableDivs;
            }

            return View(objectMoveableDivs);

        }

        // GET: JsonFile
        public ActionResult IndexGroupWidth()
        {
            //
            // Added 3/21/2020 Thomas Downes  
            //
            //JsonFile objectJsonFile = new JsonFile();
            var objectJsonFile = JsonFileController.JsonFile_MoveableDivs;

            return View(objectJsonFile);

        }

        // GET: JsonFile
        public ActionResult MoveableDivImage()
        {
            //
            // Added 4/06/2020 Thomas Downes  
            //
            var objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);

            return View(objectMoveableDivs);

        }





        // GET: JsonFile
        public ActionResult LayoutOfElements()
        {
            //
            // Added 4/02/2020 Thomas Downes  
            //
            var objectJsonFile = JsonFileController.JsonFile_MoveableDivs;
            var objectJSON = new JsonFile();


            return View(objectJsonFile);

        }


        //// GET: JsonFile
        //public ActionResult Index()
        //{
        //    //
        //    // Added 3/21/2020 Thomas Downes  
        //    //
        //    //JsonFile objectJsonFile = new JsonFile();
        //    var objectJsonFile = JsonFileController.JsonFile_MoveableDivs;
        //
        //    return View(objectJsonFile);
        //
        //}

        // GET: JsonFile
        public ActionResult TestModeSwitching()
        {
            //
            // Added 3/25/2020 Thomas Downes 
            //
            //   I want to test the mode-switching look & feel (& features,
            //   such as alignment left-edge, top-edge, etc.)
            //
            return View();
        }

        // GET: JsonFile
        public ActionResult TestExportFromModule()
        {
            //
            // Added 3/25/2020 Thomas Downes 
            //
            //  https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/export
            //
            //  https://stackoverflow.com/questions/15760462/why-does-typescript-use-the-keyword-export-to-make-classes-and-interfaces-publ
            //
            return View();
        }

        // POST: JsonFile/Index/5
        [HttpPost]
        public ActionResult Index(FormCollection collection) //  int id, FormCollection collection)
        {
            try
            {
                // Save the JSON string with the Left & Top positions of the elements. 

                //Added 3/21/2020 thomas downes
                // 3/24/2020 td//JsonFile_MoveableDivs.JsonTextContent = collection["JsonTextContent"];

                //Added 4/16/2020 thomas downes 
                const bool c_boolJsonFileObject = false;
                const bool c_boolMoveableDivs = true;

                if (c_boolMoveableDivs)
                {
                    //
                    //Added 4/16/2020 thomas downes
                    //
                    var objectMoveableDivs = JsonFileController.MoveableDivs;
                    objectMoveableDivs.SavePositions_Left(collection["JsonTextContent_Left"]);
                    objectMoveableDivs.SavePositions_Top(collection["JsonTextContent_Top"]);
                    objectMoveableDivs.SavePositions_Width(collection["JsonTextContent_Width"]);
                    objectMoveableDivs.SavePositions_Height(collection["JsonTextContent_Height"]);

                    //Added 4/16/2020 td
                    //
                    //  Transfer the positions to the element-fields stored in the cache. 
                    //
                    objectMoveableDivs.SavePositions_ToCache();

                    //Added 4/16/2020 td
                    //  We need to refresh the four(4) JSON-string properties. 
                    objectMoveableDivs.JSON_Left = collection["JsonTextContent_Left"];
                    objectMoveableDivs.JSON_Top = collection["JsonTextContent_Top"];
                    objectMoveableDivs.JSON_Width = collection["JsonTextContent_Width"];
                    objectMoveableDivs.JSON_Height = collection["JsonTextContent_Height"];

                    return View(objectMoveableDivs);

                }

                if (c_boolJsonFileObject)
                {
                    //Conditioned 4/16/2020 thomas downes 
                    JsonFile_MoveableDivs.JsonTextContent_Left = collection["JsonTextContent_Left"];
                    JsonFile_MoveableDivs.JsonTextContent_Top = collection["JsonTextContent_Top"];

                    //Added 3/30/2020 thomas downes
                    JsonFile_MoveableDivs.JsonTextContent_Width = collection["JsonTextContent_Width"];
                    JsonFile_MoveableDivs.JsonTextContent_Height = collection["JsonTextContent_Height"];

                    //
                    // Important.... save to disk. 
                    //
                    //----**---Not sure if this is needed right now.---- 3/22/2020 thomas d. 
                    //----*--
                    JsonFile_MoveableDivs.Save();

                    //return RedirectToAction("Index");
                    var objectJsonFile = JsonFileController.JsonFile_MoveableDivs;
                    return View(objectJsonFile);
                }

            }
            catch (Exception ex_Index)
            {
                //return View();
                var objContent = new ContentResult(); // "Unfortunately, the save failed." + ex_Index.Message);

                //Added 4/16/2020 thomas downes 
                objContent.Content = ("Unfortunately, the save failed." + ex_Index.Message);
                return objContent; 
            }
        }

     
    }
}
