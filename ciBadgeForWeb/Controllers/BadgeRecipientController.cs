using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    //
    //Recipient = Student or Employee receiving the Badge. 
    //
    public class BadgeRecipientController : Controller
    {
        // GET: BadgeRecipient
        public ActionResult Index()
        {
            //
            //  Index = No further specification was made.  Enact "parental"/default behavior.  
            //

            return View();
        }

        // GET: BadgeRecipient/Details/5
        public ActionResult Details(int parameter_id)
        {
            return View();
        }

        // GET: BadgeRecipient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BadgeRecipient/Create
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

        // GET: BadgeRecipient/Edit/5
        public ActionResult Edit(int parameter_id)
        {
            return View();
        }

        // POST: BadgeRecipient/Edit/5
        [HttpPost]
        public ActionResult Edit(int parameter_id, FormCollection collection)
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

        // GET: BadgeRecipient/Delete/5
        public ActionResult Delete(int parameter_id)
        {
            return View();
        }

        // POST: BadgeRecipient/Delete/5
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
