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
            //const bool c_boolSpecifyViewName = true;    //Added 5/28/2019 td
            //if (c_boolSpecifyViewName) return View("Index");  //A View, i.e. a webpage, is the most popular type of ActionResult !!
            //return View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!

            return View(mod_recipientList);

        }

        // GET: Recipient/Details/5
        public ActionResult Details(int parameter_id)
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
        public ActionResult Edit(int parameter_id)   // (int parameter_id) <=== Is it perilous to prefix the parameter? 
        {
            //const bool c_boolSpecifyViewName = true; //Added 5/28/2019 td
            //if (c_boolSpecifyViewName) return View("Edit");  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            //return View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!

            var id_doublecheck = Request.QueryString["parameter_id"];

            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            var recipients_by_id_list = mod_recipientList.Where(s => s.RecipientID == parameter_id.ToString());
            var recipient_by_id_onlyone = recipients_by_id_list.FirstOrDefault();
            //return View(recipients_by_id);
            //return View("Index", recipients_by_id);
            return View(recipient_by_id_onlyone);

        }

        public ActionResult EditNonambiguous(int parameter_id, string name)
        {
            // do something here

            return View(mod_recipientList);
        }

        // POST: Recipient/Edit/5    // (int parameter_id) <=== Is it perilous to prefix the parameter?
        [HttpPost]
        public ActionResult Edit(int parameter_id, FormCollection collection)
        {

            var id_doublecheck = Request.QueryString["RecipientID"];
            var LastName_doublecheck = Request.QueryString["LastName"];
            var FirstName_doublecheck = Request.QueryString["FirstName"];



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
        public ActionResult Delete(int parameter_id)
        {
            const bool c_boolSpecifyViewName = true; //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Delete");  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            return View();
        }

        // POST: Recipient/Delete/5
        [HttpPost]
        public ActionResult Delete(int parameter_id, FormCollection collection)
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
