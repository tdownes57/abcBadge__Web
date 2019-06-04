using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    public class TestingParamsController : Controller
    {
        // GET: TestingParams
        public ActionResult Index()
        {
            //return View();
            return (HttpNotFoundResult)HttpNotFound();
        }

        public ActionResult TestingParams(object p1, object p2, object p3, int p4)
        {
            return (ContentResult)Content(@"Testing params.... p1: {p1} p2: {p2} p3: {p3} p4: {p4} ");
        }

    }
}