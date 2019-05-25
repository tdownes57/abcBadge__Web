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

    public class RecipientController : Controller
    {
        //
        //Recipient = Student or Employee receiving the Badge. 
        //

        // GET: Recipient
        public ActionResult Index()
        {
            return View();  //A View, i.e. a webpage, is the most popular type of ActionResult !!
        }

        // GET: Recipient/Details/5
        public ActionResult Details(int id)
        {
            return View();  //A View, i.e. a webpage,  is the most popular type of ActionResult !!
        }

        // GET: Recipient/Create
        public ActionResult Create()
        {
            return View();   //A View, i.e. a webpage,  is the most popular type of ActionResult !!
        }

        // POST: Recipient/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                //Index = "Nothing specified, go to the root page or action."  
                return RedirectToAction("Index");
            }
            catch
            {
                return View();  //A View, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }

        // GET: Recipient/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recipient/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                //Index = "Nothing specified, go to the root page or action."  
                return RedirectToAction("Index");  //A Redirect is a less-common ActionResult.  ----5/24 td
            }
            catch
            {
                return View();
            }
        }

        // GET: Recipient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recipient/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                //Index = "Nothing specified, go to the root page or action."  
                //
                return RedirectToAction("Index");  //A Redirect is a less-common ActionResult.  ----5/24 td
            }
            catch
            {
                return View();  //A View, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }
    }
}
