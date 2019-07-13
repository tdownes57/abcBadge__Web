using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //Added 7/12/2019 td
using System.ComponentModel.DataAnnotations; //Added 7/12/2019 td

namespace ciBadgeForWeb.Models
{
    //
    //Added 7/12/2019 Thomas DOWNES
    //
    public class CustomDateField
    {
        //
        //Added 7/12/2019 Thomas DOWNES
        //

        [Key]
        [Display(Name = "Config ID")]
        public int ConfigID { get; set; }

        [Key]
        [Display(Name = "Custom Date-Field ID")]
        public int CustomDateFieldID { get; set; }

        [Display(Name = "Label Caption")]
        public string LabelCaption { get; set; }


        //Optional.... not certainly necessary, but possibly useful.

        [Display(Name = "Name in brief")]
        public string NameShort { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }


        [Display(Name = "If applies, Field in s.i.s. db")]
        public string FieldnameInSIS { get; set; }

    }
}