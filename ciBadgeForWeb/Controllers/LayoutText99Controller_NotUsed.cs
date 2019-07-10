using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{

    public class LayoutText99Controller_NotUsed : Controller
    {
        //
        //Added 7/04/2019 thomas downes  
        //
        public static ciLayoutPrintLib.CILayoutBadge mod_objLayout = new ciLayoutPrintLib.CILayoutBadge();

        // GET: LayoutText99
        public ActionResult Index()
        {
            //return View();
            return View(mod_objLayout);
        }

        // GET: LayoutText99/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LayoutText99/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LayoutText99/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LayoutText99/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LayoutText99/Edit/5
        [HttpPost]
        public ActionResult Index(int id, FormCollection formValues)
        {
            try
            {
                // TODO: Add update logic here
                FormCollection formValues_T1 = mod_objLayout.FormValues_T1(formValues);
                FormCollection formValues_T2 = mod_objLayout.FormValues_T2(formValues);

                UpdateModel(mod_objLayout.T1, formValues_T1);
                UpdateModel(mod_objLayout.T2, formValues_T2);

                //dinnerRepository.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LayoutText99/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LayoutText99/Delete/5
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
