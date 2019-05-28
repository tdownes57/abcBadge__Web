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
        IList<Models.CIRecipient> mod_recipientList = new List<Models.CIRecipient>() {
                    new Models.CIRecipient(){ RecipientID ="1", FirstName="John", LastName = "Davidson" },
                    new Models.CIRecipient(){ RecipientID ="2", FirstName="Steve", LastName = "Austin" },
                    new Models.CIRecipient(){ RecipientID ="3", FirstName="Bill", LastName = "Clinton"  },
                    new Models.CIRecipient(){ RecipientID ="4", FirstName="Ram", LastName = "Thegot"  },
                    new Models.CIRecipient(){ RecipientID ="5", FirstName="Ron" , LastName = "Wood" },
                    new Models.CIRecipient(){ RecipientID ="6", FirstName="Christopher", LastName = "Forbes"  },
                    new Models.CIRecipient(){ RecipientID = "7", FirstName="Robin", LastName = "Forbes"  }
                };

        // GET: Recipient
        public ActionResult Index()
        {
            const bool c_boolSpecifyViewName = true;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Index");  //A View, i.e. a webpage, is the most popular type of ActionResult !!
            return View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
        }

        // GET: Recipient/Details/5
        public ActionResult Details(int id)
        {
            return View();  //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!
        }

        // GET: Recipient/Create
        public ActionResult Create()
        {
            return View();   //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!
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
                return View();  //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }

        // GET: Recipient/Edit/5
        public ActionResult Edit(int id)
        {
            const bool c_boolSpecifyViewName = true; //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Edit");  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            return View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
        }

        // POST: Recipient/Edit/5
        [HttpPost]
        public ActionResult Edit(int parameter_id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                //
                //Get the student from studentList sample collection for demo purpose.
                //Get the student from the database in the real application
                var std = mod_recipientList.Where(s => s.RecipientID == parameter_id.ToString()).FirstOrDefault();

                //Index = "Nothing specified, go to the root page or action."  
                return RedirectToAction("Index");  //A Redirect is a less-common ActionResult.  ----5/24 td
            }
            catch
            {
                return View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            }
        }

        // GET: Recipient/Delete/5
        public ActionResult Delete(int id)
        {
            const bool c_boolSpecifyViewName = true; //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Delete");  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
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
                return View();  //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }
    }
}
