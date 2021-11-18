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
        private static List<ciBadgeForWeb.Models.Field> _fieldsListAny; //Suffixed 11/17/2021 td
        private static List<ciBadgeForWeb.Models.Field> _fieldsListStandard; //Added 11/17/2021 td
        private static List<ciBadgeForWeb.Models.Field> _fieldsListCustom; //Added 11/17/2021 td

        //---=-public static List<ciBadgeFields.ClassFieldAny> GetFieldsList()
        public static List<ciBadgeForWeb.Models.Field> GetFieldsListAny()
        {
            //Added 11/15/2021 thomas downes 
            if (_fieldsListAny == null) RefreshFieldsList();
            return _fieldsListAny;
        }

        /// <summary>
        /// Use this in conjunction with GetFieldsList(), as needed.
        /// </summary>
        public static void RefreshFieldsList()
        {
            //Added 11/15/2021 td
            //
            //_fieldsList = ClassElementsCache_Deprecated.Singleton.ListOfFields_CreateCopies();
            var list_standard = ClassElementsCache_Deprecated.Singleton.ListOfFields_Standard;
            var list_custom = ClassElementsCache_Deprecated.Singleton.ListOfFields_Custom;

            //Added 11/17/2021 td
            _fieldsListStandard = new List<Field>(); //Built from ciBadgeFields.ClassFieldStandard.
            _fieldsListCustom = new List<Field>(); //Built from ciBadgeFields.ClassFieldCustom.

            //_fieldsList = Field.ListOfFields_CreateCopies(list_standard, list_custom);
            _fieldsListAny = Field.ListOfFields_CreateCopies(list_standard, list_custom,
                                        ref _fieldsListStandard, 
                                        ref _fieldsListCustom);
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

            if (_fieldsListAny == null) RefreshFieldsList();
            return View(_fieldsListAny);

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
        public ActionResult AdvancedForOne(int id)
        {
            //----public ActionResult Advanced(int id)
            //
            //Suffixed 11/17/2021 td 
            //
            //return View();
            //return View("EditSimple");
            var fields_list = ciBadgeElements.ClassElementsCache_Deprecated.Singleton.ListOfFields_Any();
            var fields_onlyone = fields_list.Where(x => x.FieldIndex == id).FirstOrDefault();
            return (ViewResult)View("AdvancedForOne", fields_onlyone);
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
