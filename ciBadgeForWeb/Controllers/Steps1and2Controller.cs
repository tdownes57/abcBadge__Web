using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    public class Steps1and2Controller : Controller
    {
        // GET: Steps1and2
        public ActionResult Index()
        {
            return View();
        }

        // GET: Steps1and2/Details/5
        public ActionResult Details(int parameter_id)
        {
            return View();
        }

        // GET: Steps1and2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Steps1and2/Create
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

        // GET: Steps1and2/Edit/5
        public ActionResult Edit(object parameter_id)
        {
            //const bool c_boolSpecifyViewName = true;    //Added 5/28/2019 td
            //if (c_boolSpecifyViewName) return View("Edit");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            return View();
        }

        // POST: Steps1and2/Edit/5
        [HttpPost]
        public ActionResult Edit(object parameter_id, FormCollection collection)
        {
            try
            {
                //
                // TODO: Add update logic here
                //

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Steps1and2/Delete/5
        public ActionResult Delete(int parameter_id)
        {
            return View();
        }

        // POST: Steps1and2/Delete/5
        [HttpPost]
        public ActionResult Delete(int parameter_id, FormCollection collection)
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
