using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeElements;  //Added 1/19/2020 thomas downes  
using ciBadgeForWeb.Models;  //Added 11/16/2021 thomas downes

namespace ciBadgeForWeb.Controllers
{
    public class FieldsController : Controller
    {
        //
        // Added 11/15/2021 thomas downes
        //
        //---=-private static List<ciBadgeFields.ClassFieldAny> _fieldsList;
        private static List<ciBadgeForWeb.Models.Field> _fieldsList;

        //---=-public static List<ciBadgeFields.ClassFieldAny> GetFieldsList()
        public static List<ciBadgeForWeb.Models.Field> GetFieldsList()
        {
            //Added 11/15/2021 thomas downes 
            if (_fieldsList == null) RefreshFieldsList();
            return _fieldsList;
        }

        /// <summary>
        /// Use this in conjunction with GetFieldsList(), as needed.
        /// </summary>
        public static void RefreshFieldsList()
        {
            //Added 11/15/2021 td
            //
            //_fieldsList = ClassElementsCache_Deprecated.Singleton.ListOfFields_CreateCopies();
            _fieldsList = Field.ListOfFields_CreateCopies();
            //return _fieldsList;
        }

        public FieldsController()
        {
            //
            // Added 11/15/2021 td  
            //
            //----_fieldsList = RefreshFieldsList();
            RefreshFieldsList();

        }

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
            //----return View(ClassElementsCache_Deprecated.Singleton.ListOfFields_Any());

            if (_fieldsList == null) RefreshFieldsList();
            return View(_fieldsList);

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
            //---return (ViewResult)View("EditSimple", fields_onlyone);
            return (ViewResult)View(fields_onlyone);
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
                //--- 4/22/2020 td //return RedirectToAction("Index");
                var fields_list = ciBadgeElements.ClassElementsCache_Deprecated.Singleton.ListOfFields_Any();
                var field_edited = fields_list.Where(x => x.FieldIndex == id).FirstOrDefault();
                UpdateModel(field_edited, collection);

                //Added 4/22/2020 thomas downes
                ciBadgeElements.ClassElementsCache_Deprecated.Singleton.SaveToXML();

                //return RedirectToAction("Edit", id);
                //return RedirectToAction("Index");
                //return Index();
                var objContent = new ContentResult();
                objContent.Content = "Your edit has been saved.";
                return objContent;
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
