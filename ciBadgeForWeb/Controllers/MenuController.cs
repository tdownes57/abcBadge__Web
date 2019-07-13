using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeForWeb.Models;  //Added 7/12/2019 Thomas DOWNES   

//
//    https://stackoverflow.com/questions/42701480/load-menus-dynamically-in-layout-page-asp-net-mvc5
//
//    https://stackoverflow.com/questions/21948909/asp-net-mvc-controller-for-layout
//
namespace ciBadgeForWeb.Controllers
{
    //
    //    https://stackoverflow.com/questions/42701480/load-menus-dynamically-in-layout-page-asp-net-mvc5
    //
    //    https://stackoverflow.com/questions/21948909/asp-net-mvc-controller-for-layout
    //
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            //return View();

            var _menu = new Menu();
            _menu.Name = "Main Menu";

            var items = new List<MenuItem>() { new MenuItem { Name = "FirstMenu", ControllerName = "Home", ActionName = "Index" } };

            _menu.MenuItems = items;

            return View(_menu);

        }
    }
}