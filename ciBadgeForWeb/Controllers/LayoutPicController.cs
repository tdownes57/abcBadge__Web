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
    public class LayoutPicController : Controller
    {
        //Added 7/10/2019 thomas downes  
        //
        public static ciLayoutPrintLib.CILayoutPic mod_objLayoutPic = new ciLayoutPrintLib.CILayoutPic();

        // GET: CILayoutPic
        public ActionResult Index()
        {
            //return View();
            //CILayoutText obj_layoutText = new CILayoutText();
            //return View(obj_layoutText);

            // ADDED 7/6/2019 TD
            // 7-6-2019 td//ciLayoutPrintLib.LayoutExample.RefreshChoiceOfBackground_Next();

            return View(mod_objLayoutPic);
        }

        // GET: CILayoutPic/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CILayoutPic/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CILayoutPic/Create
        [HttpPost]
        public ActionResult Save(FormCollection formValues)
        {
            try
            {
                // TODO: Add insert logic here

                // Added 6/25/2019
                UpdateModel(mod_objLayoutPic, formValues); // Automatically updates properties with values from the collection

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CILayoutPic/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CILayoutPic/Edit/5
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
                UpdateModel(mod_objLayoutPic, formValues); // Automatically updates properties with values from the collection

                //dinnerRepository.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CILayoutPic/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CILayoutPic/Delete/5
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


