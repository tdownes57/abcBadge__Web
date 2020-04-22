using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeElements;  //Added 1/19/2020 thomas downes  

namespace ciBadgeForWeb.Controllers
{
    public class FieldsController : Controller
    {
        // GET: Fields
        public ActionResult Index()
        {
            //return View();
            //return View(ClassElementsCache_Deprecated.Singleton.ListOfElementFields);
            //return View(ClassElementsCache_Deprecated.Singleton.ListOfFields_Any());
            return Advanced();
        }

        // GET: Fields
        public ActionResult Simple()
        {
            //Added 2/20/2020 thomas downes 
            return View(ClassElementsCache_Deprecated.Singleton.ListOfFields_Any());
        }

        // GET: Fields
        public ActionResult Advanced()
        {
            //Added 2/20/2020 thomas downes 
            return View(ClassElementsCache_Deprecated.Singleton.ListOfFields_Any());
        }

        // GET: Fields/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fields/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fields/Create
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

        // GET: Fields/Edit/5
        public ActionResult Edit(int id)
        {
            //return View();
            //return View("EditSimple");
            var fields_list = ciBadgeElements.ClassElementsCache_Deprecated.Singleton.ListOfFields_Any();
            var fields_onlyone = fields_list.Where(x => x.FieldIndex == id).FirstOrDefault();
            return (ViewResult)View("EditSimple", fields_onlyone);
        }

        // GET: Fields/Advanced/5
        public ActionResult Advanced(int id)
        {
            //return View();
            //return View("EditSimple");
            var fields_list = ciBadgeElements.ClassElementsCache_Deprecated.Singleton.ListOfFields_Any();
            var fields_onlyone = fields_list.Where(x => x.FieldIndex == id).FirstOrDefault();
            return (ViewResult)View("Advanced", fields_onlyone);
        }


        // POST: Fields/Edit/5
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

        // POST: Fields/Edit/5
        [HttpPost]
        public ActionResult EditSimple(int id, FormCollection collection)
        {
            try
            {
                // Added 2/20/2020 thomas downes 

                var fields_list = ciBadgeElements.ClassElementsCache_Deprecated.Singleton.ListOfFields_Any();
                var fields_onlyone = fields_list.Where(x => x.FieldIndex == id);
                return (ViewResult)View(fields_onlyone);

            }
            catch
            {
                return View();
            }
        }

        // GET: Fields/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fields/Delete/5
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
