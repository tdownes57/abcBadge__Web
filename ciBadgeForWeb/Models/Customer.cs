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




    }
}