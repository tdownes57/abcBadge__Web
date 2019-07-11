using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    public class PersonalityController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        //
        //Added 7/10/2019 td
        //
        //
        //Recipient = Student or Employee receiving the Badge. 
        //
        public static IList<Models.Personality> mod_Personalities = new List<Models.Personality>() {
          new Models.Personality() { ConfigID = 1, ConfigNameBrief = "Students"  },
          new Models.Personality() { ConfigID = 2, ConfigNameBrief = "Staff" }
        };

        // GET: Personality
        public ActionResult Index()
        {
            return View();
        }

        // GET: Personality/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Personality/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personality/Create
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

        // GET: Personality/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Personality/Edit/5
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

        // GET: Personality/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Personality/Delete/5
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
