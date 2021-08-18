using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeForWeb.Models;
using ciLayoutPrintLib;  //Added 6/27/2019 thomas downes 

//
//Added 6/25/2019 thomas downes  
//
namespace ciBadgeForWeb.Controllers
{
    //
    // For [HandleError], please make sure that CustomError mode is on in System.web section of web.config,  
    //    in order for the Attribute [HandleError] (HandleErrorAttribute) work properly.
    //    https://www.tutorialsteacher.com/mvc/filters-in-asp.net-mvc
    //    -----3/7/2020 thomas d.
    //

    [HandleError]
    public class LayoutText1Controller : Controller
    {
        //Added 6/25/2019 thomas downes  
        //
        //public static Models.CILayoutText mod_objLayoutText_NA = new Models.CILayoutText();
        public static ciLayoutPrintLib.CILayoutText mod_objLayoutText = new ciLayoutPrintLib.CILayoutText();

        // GET: CILayoutText
        public ActionResult Index()
        {
            //return View();
            //CILayoutText obj_layoutText = new CILayoutText();
            //return View(obj_layoutText);

            // ADDED 7/6/2019 TD
            // 7-6-2019 td//ciLayoutPrintLib.LayoutExample.RefreshChoiceOfBackground_Next();

            const bool b_UseCodePriorToApril2020 = false;  // Added 8/17/2021 Thomas downes
            if (b_UseCodePriorToApril2020)  // Added 8/17/2021 Thomas downes
            {
                return View(mod_objLayoutText);
            }

            //
            //Added 8/17/2020 td
            //
            //---return View(JsonFileController.GetMoveableDivs());
            //;;;;return JsonFileController.GetMoveableDivs();
            //[[[[return JsonFileController.Index();
            //????return (new JsonFileController()).Index();

            // See http://www.binaryintellect.net/articles/8e64d05b-ab2e-45f6-b7f5-b8a90168915e.aspx 
            //  ---8/17/2021 td
            return RedirectToAction("Index", "JsonFile");

        }

        // GET: CILayoutText/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CILayoutText/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CILayoutText/Create
        [HttpPost]
        public ActionResult Save(FormCollection formValues)
        {
            try
            {
                // TODO: Add insert logic here

                // Added 6/25/2019
                UpdateModel(mod_objLayoutText, formValues); // Automatically updates properties with values from the collection

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CILayoutText/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CILayoutText/Edit/5
        [HttpPost]
        public ActionResult Index(FormCollection formValues)
        {
            try
            {
                // Added 6/25/2019
                //
                //mod_objLayoutText.TopEdgePositionPixels = collection["TopEdgePositionPixels"].value;
                //mod_objLayoutText.LeftEdgePositionPixels = collection.count;

                // Added 6/25/2019
                UpdateModel(mod_objLayoutText, formValues); // Automatically updates properties with values from the collection
                
                //dinnerRepository.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CILayoutText/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CILayoutText/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
