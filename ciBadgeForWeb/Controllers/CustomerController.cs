using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    //
    //
    //Helpful links:   
    //
    //    custom routes with 2 parameters, id and customerid - Stack Overflow
    //    https://stackoverflow.com/questions/1564565/custom-routes-with-2-parameters-id-and-customerid
    //
    //

    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View(); //A View, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View(); //A View, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            //Index = "Nothing specified, go to the root page or action."  
            //
            return View(); //A View, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here


                //Index = "Nothing specified, go to the root page or action."  
                //
                return RedirectToAction("Index");  //A Redirect is a less-common ActionResult.  ----5/24 td
            }
            catch
            {
                return View(); //A View, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here



                //Index = "Nothing specified, go to the root page or action."  
                //
                return RedirectToAction("Index");  //A Redirect is a less-common ActionResult.  ----5/24 td
            }
            catch
            {
                return View(); //A View, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
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
                return View(); //A View, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }
    }
}
