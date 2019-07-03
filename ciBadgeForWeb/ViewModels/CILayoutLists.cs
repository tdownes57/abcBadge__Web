using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //Added 5/28/2019 td
using System.ComponentModel.DataAnnotations; //Added 5/28/2019 td
using System.Drawing; //Added 6/13/2019 thomas d. 
using ciLayoutPrintLib; //Added 7/2/2019 td

namespace ciBadgeForWeb.Models.ViewModels
{
    public class CILayoutLists
    {

        public List<CILayoutText> LayoutTextFields = new List<CILayoutText>();
        public List<CILayoutPic> LayoutPics = new List<CILayoutPic>();
        

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
            strOutput = $"CILayoutText {this.FieldName} has a big problem.";
            return strOutput;
        }

    }
}
