using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//
//    https://stackoverflow.com/questions/42701480/load-menus-dynamically-in-layout-page-asp-net-mvc5
//
namespace ciBadgeForWeb.Models
{
    //
    //    https://stackoverflow.com/questions/42701480/load-menus-dynamically-in-layout-page-asp-net-mvc5
    //
    public class MenuItem
    {
        public int Id { get; set; }
        public int UserName { get; set; }
        public string Name { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string Url { get; set; }
        public Menu ParentMenu { get; set; }

    }
}