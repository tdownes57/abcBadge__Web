using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ActionResult Index()
        {
            //
            //  Index = No further specification was made.  Enact "parental"/default behavior.  
            //
            return View();  //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }
    }
}