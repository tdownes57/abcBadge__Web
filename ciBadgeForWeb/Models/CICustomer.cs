using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciBadgeForWeb.Models
{
    public class CICustomer
    {
        //
        //Customer. 
        //
        //static IList<Models.CICustomer> mod_customerList = new List<Models.CICustomer>() {
        //            new Models.CICustomer(){ CustomerCode="CIS100", CustomerName="CI Solutions" },
        //            new Models.CICustomer(){ CustomerCode="XYZ999", CustomerName="XYZ High School"  },
        //   };

        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }

    }
}