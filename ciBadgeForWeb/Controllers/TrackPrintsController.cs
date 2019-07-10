using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb.Controllers
{
    public class TrackPrintsController : Controller
    {
        //
        //Track Prints Log = Details about when, where, & how a Recipient's Badge was printed. 
        //
        public static IList<Models.TrackPrints> mod_trackPrintsLog = new List<Models.TrackPrints>() {
                    new Models.TrackPrints(){ TrackPrintsID = 1, RecipientID = "1", PrintDate = DateTime.Now },
                    new Models.TrackPrints(){ TrackPrintsID = 2, RecipientID = "2", PrintDate = DateTime.Now },
                    new Models.TrackPrints(){ TrackPrintsID = 3, RecipientID = "3", PrintDate = DateTime.Now  }
        };

        // GET: TrackPrints
        public ActionResult Index()
        {
            return View();
        }

        // GET: TrackPrints/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

 

    }
}
