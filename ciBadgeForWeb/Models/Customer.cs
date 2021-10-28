using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //Added 5/28/2019 td  

    //Added 5/28/2019 td  


namespace ciBadgeForWeb.Models
{
    public class Customer
    {
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