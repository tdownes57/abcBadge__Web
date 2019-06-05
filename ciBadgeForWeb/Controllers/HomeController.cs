using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult Index(int? id)
        //{
        //    return View();  //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        //}

        public ActionResult Index(Nullable<int> parameter_id)
        {
            //
            //  Index = No further specification was made.  Enact "parental"/default behavior.  
            //
            //   5-24-2019 td//public ActionResult Index(int id
            //

            return (ViewResult)View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        [HttpPost]
        public ActionResult Index(Models.UserLogin objUserLogin)
        {
            if (objUserLogin.UserName.ToLower() == "Support".ToLower() && 
                objUserLogin.Password == "teal90720")
                return RedirectToAction("WelcomePage");

            else
            {
                objUserLogin.Message = "Invalid UserName/Password";
                return View(objUserLogin);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return (ViewResult)View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return (ViewResult)View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        public ActionResult Example()
        {
            ViewBag.Message = "Example of a badge.";
            //ViewBag.ToString();

            //-----6/4/2019 td
            //---return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td

            //----6/4/2019 td''return Content("This is hard-coded content."); //A ContentResult, i.e. a (mostly blank) textpage,  
            //   is the a type of ActionResult which is good for debugging the RouteConfig!!  
            //  ----5/24 td

            return (ViewResult)View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td

        }

        public ActionResult PlainTextPage()
        {
            ViewBag.Message = "Example of returning plain text (w/ parameter values if testing params)";
            //ViewBag.ToString();

            //-----6/4/2019 td
            //---return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td

            return (ContentResult)Content("Example of returning plain text (w/ parameter values if testing params)"); //A ContentResult, i.e. a (mostly blank) textpage,  
            //   is the a type of ActionResult which is good for debugging the RouteConfig!!  
            //  ----5/24 td

        }

    }
}