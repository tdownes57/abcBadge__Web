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

            return View(objectJsonFile);

        }


        // POST: JsonFile/Index/5
        [HttpPost]
        public ActionResult Index(FormCollection collection) //  int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

     
    }
}
