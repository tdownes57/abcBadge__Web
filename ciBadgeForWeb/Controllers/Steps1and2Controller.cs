using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{   
    public class Steps1and2Controller : Controller
    {
        //
        //Recipient = Student or Employee receiving the Badge. 
        //
        static IList<Models.CIRecipient> mod_recipientList = new List<Models.CIRecipient>() {
                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="2", FirstName="Steve", LastName = "Austin" },
                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="3", FirstName="Bill", LastName = "Clinton"  },
                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="4", FirstName="Ram", LastName = "Thegot"  },
                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="5", FirstName="Ron" , LastName = "Wood" },
                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="6", FirstName="Christopher", LastName = "Forbes"  },
                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID = "7", FirstName="Robin", LastName = "Forbes"  },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="1", FirstName="John", LastName = "Davidson" },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="2", FirstName="Steve", LastName = "Austin" },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="3", FirstName="Bill", LastName = "Clinton"  },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="4", FirstName="Ram", LastName = "Thegot"  },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="5", FirstName="Ron" , LastName = "Wood" },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="6", FirstName="Christopher", LastName = "Forbes"  },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID = "7", FirstName="Robin", LastName = "Forbes"  }
};

        // GET: Steps1and2
        public ActionResult Index()
        {
            return View();
        }


        // POST: Steps1and2/Search  
        [HttpGet]
        public ActionResult Search(object par_lastname)  //6/6/2019  ---- , FormCollection collection)
        {
            try
            {
                //
                // TODO: Add update logic here
                //
                var recipients_by_id_list = mod_recipientList.Where(s => s.LastName == par_lastname.ToString());
                var recipient_by_id_onlyone = recipients_by_id_list.FirstOrDefault();
                //return (ViewResult)View(recipient_by_id_onlyone);
                return RedirectToAction("Edit", recipient_by_id_onlyone.RecipientID);

            }
            catch
            {
                return View();
            }
        }


        // GET: Steps1and2/Details/5
        public ActionResult Details(int parameter_id)
        {
            return View();
        }

        // GET: Steps1and2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Steps1and2/Create
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

        // GET: Steps1and2/Edit/5
        public ActionResult Edit(int? parameter_id)
        {
            if (!(parameter_id.HasValue)) return View();

            const bool c_boolSpecifyViewName = false; //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Edit");  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            //return View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!

            //var id_doublecheck = Request.QueryString["parameter_id"];

            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            var recipients_by_id_list = mod_recipientList.Where(s => s.RecipientID == parameter_id.ToString());
            var recipient_by_id_onlyone = recipients_by_id_list.FirstOrDefault();
            //return View(recipients_by_id);
            //return View("Index", recipients_by_id);
            return (ViewResult)View(recipient_by_id_onlyone);

        }

        // POST: Steps1and2/Edit/5
        [HttpPost]
        public ActionResult Edit(object parameter_id, FormCollection collection)
        {
            try
            {
                //
                // TODO: Add update logic here
                //

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Steps1and2/Delete/5
        public ActionResult Delete(int parameter_id)
        {
            return View();
        }

        // POST: Steps1and2/Delete/5
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
