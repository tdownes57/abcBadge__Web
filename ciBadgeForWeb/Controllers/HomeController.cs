using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeForWeb.Models;  //Added 8/10/2019 thomas downes   
//using EntityFramework;  //Added 8/15/2019 td  

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
            ciPictures_VB.PictureExamples.PathToFolderOfImages = (HttpRuntime.AppDomainAppPath + "Images\\PictureExamples");
            ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");

            return View();
        }

        public ActionResult LoginPlain()
        {
            //
            //  https://www.c-sharpcorner.com/article/simple-login-application-using-Asp-Net-mvc/ 
            //
            ciPictures_VB.PictureExamples.PathToFolderOfImages = (HttpRuntime.AppDomainAppPath + "Images\\PictureExamples");
            ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin objUser)
        {
            //
            //  https://www.c-sharpcorner.com/article/simple-login-application-using-Asp-Net-mvc/ 
            //
            ciPictures_VB.PictureExamples.PathToFolderOfImages = (HttpRuntime.AppDomainAppPath + "Images\\PictureExamples");
            ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");

            if (ModelState != null && ModelState.IsValid)
            {
                //  8/15/2019 td''using (DB_Entities db = new DB_Entities())
                //{
                //    var obj = db.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                //    if (obj != null)
                //    {
                //        Session["UserID"] = obj.UserId.ToString();
                //        Session["UserName"] = obj.UserName.ToString();
                //        return RedirectToAction("UserDashBoard");
                //    }
                //  8/15/2019 td''}

                //bool boolUserSupport = ("support".Equals(objUser.UserName.ToLower()));

                bool boolUserSupport = false;  //Added 1/27/2020 thomas downes
                bool boolSupportPW = false;    //Added 1/27/2020 thomas downes

                if (objUser.UserName != null && objUser.Password != null)
                {
                    //
                    //Conditioned 1/27/2020 thomas downes
                    //
                    boolUserSupport = ("support".Equals(objUser.UserName.ToLower()));
                    boolSupportPW = ("teal90720".Equals(objUser.Password));

                    boolSupportPW = boolSupportPW || ("support".Equals(objUser.Password));
                    boolSupportPW = boolSupportPW || ("Support".Equals(objUser.Password));
                    boolSupportPW = boolSupportPW || ("SUPPORT".Equals(objUser.Password));
                }

                bool boolSupportAuthenticated = (boolUserSupport && boolSupportPW); 

                if (boolSupportAuthenticated)
                {
                     Session["UserID"] = objUser.UserName.ToString();
                     Session["UserName"] = objUser.UserName.ToString();
                     //return RedirectToAction("UserDashBoard");
                    return RedirectToAction("Index");
                }

            }
            return View(objUser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Bypass(UserLogin objUser)
        {
            //
            // Skip the login process. 
            //
            Session["UserID"] = "Support";
            Session["UserName"] = "Support";
            //return View(objUser);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginPlain(UserLogin objUser)
        {
            //
            //  https://www.c-sharpcorner.com/article/simple-login-application-using-Asp-Net-mvc/ 
            //
            ciPictures_VB.PictureExamples.PathToFolderOfImages = (HttpRuntime.AppDomainAppPath + "Images\\PictureExamples");
            ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");

            if (ModelState.IsValid && objUser.UserName != null && objUser.Password != null)
            {
                bool boolUserSupport = ("support".Equals(objUser.UserName.ToLower()));
                bool boolSupportPW = ("teal90720".Equals(objUser.Password));
                bool boolSupportAuthenticated = (boolUserSupport && boolSupportPW);

                if (boolSupportAuthenticated)
                {
                    Session["UserID"] = objUser.UserName.ToString();
                    Session["UserName"] = objUser.UserName.ToString();
                    //return RedirectToAction("UserDashBoard");
                    return RedirectToAction("Index");
                }

            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            //
            //  https://www.c-sharpcorner.com/article/simple-login-application-using-Asp-Net-mvc/ 
            //
            if (Session["UserID"] != null || Session["UserName"] != null)
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
            ciPictures_VB.PictureExamples.PathToFolderOfImages = (HttpRuntime.AppDomainAppPath + "Images\\PictureExamples");
            ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");

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

            //return (ViewResult)View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td

            return RedirectToRoute(new
            {
                controller = "Recipient",
                action = "Edit"
                //parameter_id = "001"
                //userId = user.Id,
                //applicantId = applicant.Id
            });

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

        public ActionResult Example_NotInUse()
        {
            //
            //Example of Badge.  
            //
            ViewBag.Message = "Your application description page.";

            return (ViewResult)View(); //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
        }

    }
}