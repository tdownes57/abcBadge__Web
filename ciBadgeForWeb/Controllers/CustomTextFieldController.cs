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
        public static IList<Models.CustomTextField> mod_customFieldsList = new List<Models.CustomTextField>() {
                    new Models.CustomTextField() { ConfigID =1, CustomTextFieldID = 1,  LabelCaption = "Teacher" },
                    new Models.CustomTextField() { ConfigID =1, CustomTextFieldID = 2, LabelCaption = "Grade (1st to 6th)"   },
                    new Models.CustomTextField() { ConfigID = 1, CustomTextFieldID = 3, LabelCaption = "School"   }
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
    }
}
