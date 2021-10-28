using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //Added 10/28/2021 td

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

        [Display(Name = "Customer ID")]
        public string CustomerCode { get; set; }

        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        // Added 10/26/2021 thomas downes
        //   This will provide secure 6-character identification,
        //   using a randomly-generated 6-character identifier. 
        [Key]
        public string Guid6Chars { get; set; }

    }
}