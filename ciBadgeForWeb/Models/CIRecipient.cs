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

        [Display(Name = "Customer ID")]
        public string CustomerID { get; set; }

        [Display(Name = "Personality")]
        public string Personality { get; set; }

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

        public string EffectiveDate_Text
        {
            //Added 5/30/2019
            get { return EffectiveDate.ToString("MM/dd/yyyy");  }
            set { EffectiveDate = DateTime.Parse(value);  }
        }

        public string ExpirationDate_Text
        {
            //Added 5/30/2019
            get { return ExpirationDate.ToString("MM/dd/yyyy"); }
            set { ExpirationDate = DateTime.Parse(value); }
        }


        public string ErrorMessage()
        {
            //
            //  https://visualstudiomagazine.com/blogs/tool-tracker/2019/05/building-strings-at-runtime.aspx
            //
            /**   Your third option is string interpolation. This is the newest mechanism and is what all 
             * the "hip and happening" developers use. It looks much like using the Format method, but the
             * placeholders now hold the values to be inserted into the string. You need to flag the string 
             * with a dollar sign ($) to tell C# that the curly braces are to be treated as placeholders rather 
             * than included in the string: 
             *  string msg = $"Customer {cust.Id} has an invalid status {cust.Status}.";  **/

            string strOutput;
            strOutput = $"Student or Employee {this.FirstName} {this.LastName} has a big problem.";
            return strOutput;  
        }

    }
}
 