using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;  

namespace ciBadgeForWeb.Controllers
{
    //
    // https://www.c-sharpcorner.com/uploadfile/dhananjaycoder/working-with-images-in-Asp-Net-mvc-framework/
    //
    public class PortraitImageController : Controller
    {
        // GET: PortraitImage
        public ActionResult Index()
        {
            return View("PortraitImageModel");
        }
    }
}