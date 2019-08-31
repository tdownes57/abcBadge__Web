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
        //
        //Customer
        //
        public static string Customer_current = "CIS100"; //Needed for the future Steps1234 controller.  ----Added 7/17/2019 td 

        public static IList<Models.CICustomer> mod_customerList = new List<Models.CICustomer>() {
                    new Models.CICustomer(){ CustomerCode="CIS100", CustomerName="CI Solutions" },
                    new Models.CICustomer(){ CustomerCode="ABC999", CustomerName="Good College" },
                    new Models.CICustomer(){ CustomerCode="XYZ999", CustomerName="XYZ High School"  },
           };

        // GET: Customer
        public ActionResult Index()
        {
            //
            //  Index = No further specification was made.  Enact "parental"/default behavior.  
            //
            const bool c_boolSpecifyViewName = false;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Index");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        // GET: Customer/Details/5
        public ActionResult Details(int parameter_id)
        {
            const bool c_boolSpecifyViewName = true;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Details");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            // 
            //
            //
            const bool c_boolSpecifyViewName = true;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Create");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
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
                const bool c_boolSpecifyViewName = true;    //Added 5/28/2019 td
                if (c_boolSpecifyViewName) return View("Create");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

                return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int parameter_id)
        {
            const bool c_boolSpecifyViewName = true;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Edit");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            return View();  //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int parameter_id, FormCollection collection)
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
                const bool c_boolSpecifyViewName = true;    //Added 5/28/2019 td
                if (c_boolSpecifyViewName) return View("Edit");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

                return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int parameter_id)
        {
            const bool c_boolSpecifyViewName = true;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Delete");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int parameter_id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here



                //Index = "Nothing specified, go to the root page or action."  
                //
                return RedirectToAction("Index");  //Probably opens the Index View.  A Redirect is 
                //   a less-common ActionResult.  ----5/24 td
            }
            catch
            {
                return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }
    }
}
