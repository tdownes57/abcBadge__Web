using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    public class Step1Controller : Controller
    {

        //
        //Recipient = Student or Employee receiving the Badge. 
        //
        //        static IList<Models.CIRecipient> mod_recipientList = new List<Models.CIRecipient>() {
        //                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="2", FirstName="Steve", LastName = "Austin" },
        //                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="3", FirstName="Bill", LastName = "Clinton"  },
        //                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="4", FirstName="Ram", LastName = "Thegot"  },
        //                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="5", FirstName="Ron" , LastName = "Wood" },
        //                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID ="6", FirstName="Christopher", LastName = "Forbes"  },
        //                    new Models.CIRecipient(){ CustomerID="CIS100", Personality="Staff", RecipientID = "7", FirstName="Robin", LastName = "Forbes"  },
        //                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="1", FirstName="John", LastName = "Davidson" },
        //                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="2", FirstName="Steve", LastName = "Austin" },
        //                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="3", FirstName="Bill", LastName = "Clinton"  },
        //                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="4", FirstName="Ram", LastName = "Thegot"  },
        //                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="5", FirstName="Ron" , LastName = "Wood" },
        //                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="6", FirstName="Christopher", LastName = "Forbes"  },
        //                    new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID = "7", FirstName="Robin", LastName = "Forbes"  }
        //};
        // 6/15/2019 td //static IList<Models.CIRecipient> mod_recipientList = Steps1and2Controller.mod_recipientList;
        static IList<Models.CIRecipient> mod_recipientList = RecipientController.mod_recipientList2;

        // GET: Step1
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ShowSearchResults(string par_lastname)
        {
            //do whatever you need with the parameter, 
            //like using it as parameter in Linq to Entities or Linq to Sql, etc. 
            //Suppose your search result will be put in variable "result".

            //ViewData.Model = result;

            var recipients_by_id_list = mod_recipientList.Where(s => s.LastName.Contains(par_lastname.ToString()));

            ViewData.Model = recipients_by_id_list;  
            return View();
        }



    }
}
