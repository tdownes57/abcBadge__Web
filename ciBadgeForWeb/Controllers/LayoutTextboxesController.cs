using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    public class LayoutTextboxesController : Controller
    {
        // GET: LayoutTextboxes
        public ActionResult Index()
        {
            return View();
        }

        // GET: LayoutTextboxes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LayoutTextboxes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LayoutTextboxes/Create
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

        // GET: LayoutTextboxes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LayoutTextboxes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: LayoutTextboxes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LayoutTextboxes/Delete/5
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
