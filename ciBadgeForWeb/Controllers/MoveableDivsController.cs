using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    public class MoveableDivsController : Controller
    {
        // GET: MoveableDivs
        public ActionResult Index()
        {
            //
            // Added 4/1/2020 thomas downes  
            //
            //  Go to the JsonController to find my "Moveable DIVs" work.
            //  ----4/1 td
            //
            return new EmptyResult();     // View();
        }
    }
}