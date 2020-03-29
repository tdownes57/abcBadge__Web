using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeForWeb.Models;  // Added 3/21/2020 Thomas Downes 

namespace ciBadgeForWeb.Controllers
{
    public class JsonFileController : Controller
    {
        //Added 3/21/2020 Thomas Downes
        public static JsonFile JsonFile_MoveableDivs = new JsonFile();

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
            return View(objectJsonFile);

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
                JsonFile_MoveableDivs.JsonTextContent_Left = collection["JsonTextContent_Left"];
                JsonFile_MoveableDivs.JsonTextContent_Top = collection["JsonTextContent_Top"];

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
            catch
            {
                return View();
            }
        }

     
    }
}
