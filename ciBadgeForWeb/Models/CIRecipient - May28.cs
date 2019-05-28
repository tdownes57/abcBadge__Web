using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //Added 5/28/2019 td
using System.ComponentModel.DataAnnotations; //Added 5/28/2019 td

namespace ciBadgeForWeb.Models
{
    public class CIRecipient
    {
        //public int Mystring { get; set; }

        [Display(Name = "ID")]
        public string RecipientID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public List<string> TextFields { get; set; }
        public List<DateTime> DateFields { get; set; }





    }
}