using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeForWeb.Models;
using ciLayoutPrintLib;  //Added 6/27/2019 thomas downes 

//
//Added 6/27/2019 thomas downes  
//
namespace ciBadgeForWeb.Controllers
{
    //
    //Added 6/27/2019 thomas downes  
    //
    public class LayoutText2Controller : Controller
    {
        //Added 6/27/2019 thomas downes  
        //
        public static ciLayoutPrintLib.CILayoutBadge mod_objLayout = new ciLayoutPrintLib.CILayoutBadge();

        // GET: CILayoutText
        public ActionResult Index()
        {
            //return View();
            //CILayoutText obj_layoutText = new CILayoutText();
            //return View(obj_layoutText);
            return View(mod_objLayout);
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
                // Added 6/25/2019
                //
                // ----- WORKED FOR LayoutText1, won't work for LayoutText2 !!!!!!   -Thursday 6/27/2019 td
                //
                UpdateModel(mod_objLayout, formValues); // Automatically updates properties with values from the collection

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
                //
                // ----- WORKED FOR LayoutText1, won't work for LayoutText2 !!!!!!   -Thursday 6/27/2019 td
                //
                //UpdateModel(mod_objLayout, formValues); // Automatically updates properties with values from the collection

                //Added 7/5/2019 thomas downes 
                //ciLayoutPrintLib.LayoutExample.RefreshChoiceOfBackground_Next();

                FormCollection formValues_T1 = mod_objLayout.FormValues_T1(formValues);
                FormCollection formValues_T2 = mod_objLayout.FormValues_T2(formValues);

                UpdateModel(mod_objLayout.T1, formValues_T1);
                UpdateModel(mod_objLayout.T2, formValues_T2);

                //Added 6/27/2019 thomas downes
                //
                //   //
                //mod_objLayout.UpdateByFormValues(formValues);
                //mod_objLayout.Update_T1();
                //mod_objLayout.Update_T2(); 

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
