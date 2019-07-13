using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    public class CustomTextFieldController : Controller
    {
        //
        //List of example custom fields. 
        //
        public static string ListOfTeachers = "Mason,Ross,Henderson,Havisu,Brown,Favreau,Halford,Cumberbatch";
        public static string ListOfGrades = "9th,10th,11th,12th";
        public static string ListOfSchools = "Canyon High,Hart High,Saugus High";

        public static IList<Models.CustomTextField> mod_customFieldsList = new List<Models.CustomTextField>() {
                    new Models.CustomTextField() { ConfigID = 1, CustomTextFieldID = 1,  LabelCaption = "Teacher", DropdownValues = true, DropdownValuesCSV = ListOfTeachers },
                    new Models.CustomTextField() { ConfigID = 1, CustomTextFieldID = 2, LabelCaption = "Grade (1st to 6th)", DropdownValues = true, DropdownValuesCSV = ListOfGrades   },
                    new Models.CustomTextField() { ConfigID = 1, CustomTextFieldID = 3, LabelCaption = "High School", DropdownValues = true   }
        };

        // GET: CustomField
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomField/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomField/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomField/Create
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

        // GET: CustomField/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomField/Edit/5
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

        // GET: CustomField/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomField/Delete/5
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

        //public static string ListOfTeachers = "Mason,Ross,Henderson,Havisu,Brown,Favreau,Halford,Cumberbatch";
        //public static string ListOfGrades = "9th,10th,11th,12th";
        //public static string ListOfSchools = "Canyon High,Hart High,Saugus High";

        //public static IList<Models.CustomTextField> mod_customFieldsList = new List<Models.CustomTextField>() {
        //            new Models.CustomTextField() { ConfigID = 1, CustomTextFieldID = 1,  LabelCaption = "Teacher", DropdownValues = true, DropdownValuesCSV = ListOfTeachers },
        //            new Models.CustomTextField() { ConfigID = 1, CustomTextFieldID = 2, LabelCaption = "Grade (1st to 6th)", DropdownValues = true, DropdownValuesCSV = ListOfGrades   },
        //            new Models.CustomTextField() { ConfigID = 1, CustomTextFieldID = 3, LabelCaption = "High School", DropdownValues = true   }
        //};

    }
}
