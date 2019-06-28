using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//
//Added 6/28/2019 Thomas Downes   
//
// https://theburningmonk.com/2010/02/converting-hex-to-int-in-csharp/
//

namespace ciBadgeForWeb.Controllers
{
    public class UploadBackController : Controller
    {
        /// <summary>
        /// https://theburningmonk.com/2010/02/converting-hex-to-int-in-csharp/
        /// </summary>
        /// <returns></returns>
        // GET: UploadBack
        public ActionResult Index()
        {
            return View();
        }

        // GET: UploadBack/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UploadBack/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UploadBack/Create
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

        // GET: UploadBack/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UploadBack/Edit/5
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

        // GET: UploadBack/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UploadBack/Delete/5
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
