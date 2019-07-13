using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //Added 7/12/2019 td
using System.ComponentModel.DataAnnotations; //Added 7/12/2019 td

namespace ciBadgeForWeb.Models
{
    public class CustomTextField
    {
        //Name
        //Description

        //Database Table
        //Database Field

        // Text or Date?
        // Editable?
        // Provide dropdown Values?
        // Only allow dropdown values, vs. free text?

        [Key]
        [Display(Name = "Config ID")]
        public int ConfigID { get; set; }

        [Key]
        [Display(Name = "Custom Text Field ID")]
        public int CustomTextFieldID { get; set; }



        [Display(Name = "Label Caption")]
        public string LabelCaption { get; set; }



        //
        //Following are optional.... not certainly necessary, but possibly useful.
        //

        [Display(Name = "FieldnameBrief")]
        public string NameShort
        {
            get; set;
        }

        [Display(Name = "Date values only?")]
        public bool DateValuesOnly { get; set; }

        [Display(Name = "Provide selectable values?")]
        public bool DropdownValues { get; set; }

        [Display(Name = "Drop-Down Values (List by commas)")]
        public string DropdownValuesCSV { get; set; }

        [Display(Name = "Full description")]
        public string FullDescription { get; set; }


        [Display(Name = "If applies, Field in s.i.s. db")]
        public string FieldnameInSIS { get; set; }

    }
}