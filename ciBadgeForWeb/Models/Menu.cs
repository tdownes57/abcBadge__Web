using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//
//    https://stackoverflow.com/questions/42701480/load-menus-dynamically-in-layout-page-asp-net-mvc5
//
//    https://stackoverflow.com/questions/21948909/asp-net-mvc-controller-for-layout
//
namespace ciBadgeForWeb.Models
{
    //
    //    https://stackoverflow.com/questions/42701480/load-menus-dynamically-in-layout-page-asp-net-mvc5
    //
    //    https://stackoverflow.com/questions/21948909/asp-net-mvc-controller-for-layout
    //
    public class Menu
    {
        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<MenuItem> MenuItems { get; set; }

    }
}