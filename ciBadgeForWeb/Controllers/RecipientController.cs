using ciPictures_VB;  //Added 6/15/2019 thomas d.  
using System.Collections.Generic;
using System.Linq;
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
        public static IList<Models.CIRecipient> mod_recipientList = new List<Models.CIRecipient>() {
                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="2", FirstName="Steve", LastName = "Austin", Picture = PictureExamples.GetExample() },
                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="3", FirstName="Bill", LastName = "Clinton", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="4", FirstName="Ram", LastName = "Thegot", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="5", FirstName="Ron" , LastName = "Wood", Picture = PictureExamples.GetExample()  },
                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="6", FirstName="Christopher", LastName = "Forbes", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID = "7", FirstName="Robin", LastName = "Forbes", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="1", FirstName="John", LastName = "Davidson", Picture = PictureExamples.GetExample()  },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="2", FirstName="Steve", LastName = "Austin", Picture = PictureExamples.GetExample()  },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="3", FirstName="Bill", LastName = "Clinton", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="4", FirstName="Ram", LastName = "Thegot", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="5", FirstName="Ron" , LastName = "Wood", Picture = PictureExamples.GetExample()  },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="6", FirstName="Christopher", LastName = "Forbes", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID = "7", FirstName="Robin", LastName = "Forbes", Picture = PictureExamples.GetExample()   }
};

        // GET: Recipient
        public ActionResult Index()
        {
            const bool c_boolSpecifyViewName = false;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Index");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            //Let's test it.  Does the List retain edits??? ----5/29/2019 td
            mod_recipientList.FirstOrDefault().LastName += "P";

            //return View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            return (ViewResult)View(mod_recipientList);
        }

        // GET: Recipient/Details/5
        public ActionResult Details(int parameter_id)
        {
            const bool c_boolSpecifyViewName = false;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Details");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            return (ViewResult)View();  //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!
        }

        // GET: Recipient/Create
        public ActionResult Create()
        {
            const bool c_boolSpecifyViewName = false;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Create");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            return (ViewResult)View();   //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!
        }

        // Recipient/ShowSearchResults   (Doesn't directly match an HTTP command.)
        public ActionResult ShowSearchResults(IList<Models.CIRecipient> par_results) => View("Index",  par_results);

        //const bool c_boolSpecifyViewName = false;    / /Added 5/28/2019 td
        //if (c_boolSpecifyViewName) return View("Create");  //A View, i.e. a webpage, is the most popular type of ActionResult !!
        //return (ViewResult)View();   //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!



        // POST: Recipient/Create
        [HttpPost]
        public ActionResult Create(Models.CIRecipient par_recip)     // (FormCollection collection)
        {
            try
            {
                // Added 6/5/2019 td
                //
                mod_recipientList.Add(par_recip);


                //Index = "Nothing specified, go to the root page or action."  
                return RedirectToAction("Index");
            }
            catch
            {
                return (ViewResult)View();  //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }

        // GET: Recipient/Edit/5
        public ActionResult Edit(int parameter_id)
        {
            const bool c_boolSpecifyViewName = false; //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Edit");  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            //return View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!

            var id_doublecheck = Request.QueryString["parameter_id"];

            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            var recipients_by_id_list = mod_recipientList.Where(s => s.RecipientID == parameter_id.ToString());
            var recipient_by_id_onlyone = recipients_by_id_list.FirstOrDefault();
            //return View(recipients_by_id);
            //return View("Index", recipients_by_id);
            return (ViewResult)View(recipient_by_id_onlyone);

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
                var edited_recip = mod_recipientList.Where(s => s.RecipientID == parameter_id.ToString()).FirstOrDefault();

                var name_first = Request["FirstName"];
                var name_last = Request["LastName"];

                edited_recip.FirstName = name_first;  // std.FirstName + "_Revised";
                edited_recip.LastName = name_last;  //  std.LastName + "_Revised";


                //Index = "Nothing specified, go to the root page or action."  
                return RedirectToAction("Index");  //A Redirect is a less-common ActionResult.  ----5/24 td
            }
            catch
            {
                return (ViewResult)View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
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
                return (ViewResult)View();  //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }
    }
}
