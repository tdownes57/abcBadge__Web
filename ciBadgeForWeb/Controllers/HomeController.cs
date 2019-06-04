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
            //5-24-2019 td//public ActionResult Index(int id)

            return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

        public ActionResult Example()
        {
            ViewBag.Message = "Example of a badge.";
            //ViewBag.ToString();

            return View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

    }
}