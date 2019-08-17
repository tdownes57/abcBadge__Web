using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeForWeb.Models;  //Added 8/10/2019 thomas downes    

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

        public ActionResult Login()
        {
            //
            //  https://www.c-sharpcorner.com/article/simple-login-application-using-Asp-Net-mvc/ 
            //
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin objUser)
        {
            //
            //  https://www.c-sharpcorner.com/article/simple-login-application-using-Asp-Net-mvc/ 
            //
            if (ModelState.IsValid)
            {
                //using (DB_Entities db = new DB_Entities())
                //{
                //var obj = db.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                //if (obj != null)

                if (objUser.Password == "teal90720" || objUser.Password == "362590720")
                {
                    Session["UserID"] = "Support";  // obj.UserId.ToString();
                    Session["UserName"] = "Support";  // obj.UserName.ToString();
                    return RedirectToAction("UserDashBoard");
                }
                //  }
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            //
            //  https://www.c-sharpcorner.com/article/simple-login-application-using-Asp-Net-mvc/ 
            //
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

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
        public ActionResult Index(ciBadgeForWeb.Models.UserLogin objUserLogin)
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