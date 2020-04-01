using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    public class OrangeCoastController : Controller
    {
        // GET: OrangeCoast
        public ActionResult Index()
        {
            //return View();
            //
            // https://richhewlett.com/2013/11/10/host-static-html-or-webforms-page-within-mvc-site/
            //
            //  return new HtmlResult("~\");
            //  return new RedirectToRouteResult();
            //  return new ViewResult("", "");

            //  Redirect to HTML Page in ASP.NET MVC
            //  http://www.softdeveloperszone.com/2013/06/redirect-to-html-page-in-aspnet-mvc.html
            //  Below code will set the default page of an ASP.NET MVC application to a HTML page.
            //
            return Redirect("~/OrangeCoast/MemeAppFinal/MemeAppFinal.html");

        }
    }
}