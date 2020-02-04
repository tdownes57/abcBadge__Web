using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //Added 5/28/2019 td
using System.ComponentModel.DataAnnotations; //Added 5/28/2019 td
using System.Drawing; //Added 6/13/2019 thomas d. 
using ciBadgeInterfaces; //Added 10/4/2019 td  
using ciBadgeElements; // Added 12/01/2019 thomas d. 
using ciPictures_VB; //Added 12/11/2019 thomas d. 
using ciBadgeForWeb.Controllers;  //Added 12/11/2019 thomas d.

namespace ciBadgeForWeb.Models
{
    public class CIRecipient : ciBadgeInterfaces.IRecipient
    {
        //public int Mystring { get; set; }

        [Key]
        [Display(Name = "Customer ID")]
        public string CustomerID { get; set; }

        [Key]
        [Display(Name = "Config ID")]
        public int idfConfigID { get; set; }

        [Key]
        [Display(Name = "ID")]
        public string RecipientID { get; set; }

        string IRecipient.RecipientID()
        {
            return this.RecipientID;
        }

        //Added 12/1/2019 thomas d.
        public ciBadgeElements.ClassElementsCache_Deprecated ParentCache { get; set; }

        //
        //Fields
        //
        List<ciBadgeFields.ClassFieldAny> ListOfCIBFields()
        {
            //
            //Added 12/1/2019 thomas d
            //
            // 12-02-2019 td''return ((ClassElementsCache)ParentCache).ListOfFields_Any();
            return ((ClassElementsCache_Deprecated)ParentCache).ListOfFields_Any(this);
        }

        public System.Drawing.Image GetPortraitImage()
        {
            // Added 11/13/2019 td 
            //11-16-2019 td//return null;
            return this.Picture;

        }

        public string fstrID //Added 10-4-2019 td 
        {
            get
                {
                return this.RecipientID;
            }
            set{
                this.RecipientID = value;
            }
        }

        public string fstrLastName //Added 10-4-2019 td 
        {
            get
            {
                //11-18-2019 td//return this.FirstName;
                return this.LastName;
            }
            set
            {
                //11-18-2019 td//this.RecipientID = value;
                this.LastName = value;
            }
        }

        public string fstrFirstName //Added 10-4-2019 td 
        {
            get
            {
                return this.FirstName;
            }
            set
            {
                this.FirstName = value;
            } 
        }

        public string fstrMidName { get; set; }
        public int intTimesPrinted { get; set; }
        public int idsCardDataID { get; set; }

        //Added 12/11/2019 td  
        private Image mod_pictureImage = null;

        [Display(Name = "Picture")]
        public Image Picture {
            get 
            {
                //12/11/2019 td 
                //#1  12-11-2019 td //if (mod_pictureImage == null) mod_pictureImage = PictureExamples.GetExample();
                // #2  12-11-2019 td //if (mod_pictureImage == null) mod_pictureImage = RecipientController.GetImageByRecipID_Null();
                if (mod_pictureImage == null) mod_pictureImage = RecipientController.GetImageByRecipID(this.fstrID);
                return mod_pictureImage;
            }
            set 
            {
                //12/11/2019 td 
                mod_pictureImage = value;
            }
         }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        //
        //Added 7/13/2019 THOMAS DOWNES
        //
        public string FullNameOnBadge { get; set; }

        //
        //Added 7/14/2019 THOMAS DOWNES
        //
        public string RFIDValue { get; set; }

        //
        //Added 11/13/2019 THOMAS DOWNES
        //
        public string fstrBarcode { get; set; }
        public string fstrRFID_Unique { get; set; }

        //
        //
        //Custom Fields
        //
        //
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateField01 { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateField02 { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateField03 { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateField04 { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateField05 { get; set; }



        public string TextField01 { get; set; }
        public string TextField02 { get; set; }
        public string TextField03 { get; set; }
        public string TextField04 { get; set; }
        public string TextField05 { get; set; }
        public string TextField06 { get; set; }
        public string TextField07 { get; set; }
        public string TextField08 { get; set; }
        public string TextField09 { get; set; }
        public string TextField10 { get; set; }
        public string TextField11 { get; set; }
        public string TextField12 { get; set; }
        public string TextField13 { get; set; }
        public string TextField14 { get; set; }
        public string TextField15 { get; set; }


        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public List<string> TextFields { get; set; }
        public List<DateTime> DateFields { get; set; }

        public string EffectiveDate_Text
        {
            //Added 5/30/2019
            get
            {
                if (EffectiveDate.Year < 2000) return ""; //Added 7/8/2019 td 
                return EffectiveDate.ToString("MM/dd/yyyy");
            }
            set
            {
                if (value == null) return;  //Added 7/8/2019 td
                EffectiveDate = DateTime.Parse(value);
            }
        }

        public string ExpirationDate_Text
        {
            //Added 5/30/2019
            get
            {
                if (ExpirationDate.Year < 2000) return ""; //Added 7/8/2019 td 
                return ExpirationDate.ToString("MM/dd/yyyy");
            }
            set
            {
                if (value == null) return;  //Added 7/8/2019 td
                ExpirationDate = DateTime.Parse(value);
            }
        }

        //
        //Added 7-13-2019 thomas d.
        //
        public Models.Personality GetRecipientsPersonality()
        {
            //
            //Added 7-13-2019 thomas d.
            //
            return Controllers.PersonalityController.mod_Personalities[this.idfConfigID];
        }

        //
        //Added 7/13/2019 Thomas C. Downes
        //
        public bool UseMiddleNameOnBadge()
        {
            //Added 7/13/2019 Thomas C. Downes
            return GetRecipientsPersonality().MiddleName;
        }

        //
        //Added 7/13/2019 THOMAS DOWNES
        //
        public string FullNameOnBadge_Composed()
        {
            bool boolUseOverride; //Added 7/13/2019
            bool boolEditsToFullnameOkay;

            //
            //Account for possible operator-judgement overrides. (Operators must use sparingly!)   
            //
            boolEditsToFullnameOkay = GetRecipientsPersonality().AllowEditsToFullName;
            boolUseOverride = (boolEditsToFullnameOkay && (!(String.IsNullOrEmpty(FullNameOnBadge.Trim()))));
            if (boolUseOverride) boolUseOverride = (3 + 1 + 2 <= FullNameOnBadge.Length);
            if (boolUseOverride) return FullNameOnBadge;

            if (UseMiddleNameOnBadge()) return (FirstName + " " + MiddleName + " " + LastName);

            return (FirstName + " " + LastName);

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

        //
        //Addeed 10/4/2019 thomas downes  
        //
        public string GetTextValue(EnumCIBFields par_enum)
        {
            switch (par_enum)
            {
                //Added 11/17/2019 td
               case EnumCIBFields.fstrFirstName : return this.fstrFirstName;
               case EnumCIBFields.fstrID : return this.fstrID;  
               case EnumCIBFields.fstrLastName : return this.fstrLastName;
               case EnumCIBFields.fstrMidName : return this.fstrMidName;

                case EnumCIBFields.DateField01: return DateField01.ToString("MM/dd/yyyy"); break;
                case EnumCIBFields.DateField02: return DateField02.ToString("MM/dd/yyyy"); break;
                case EnumCIBFields.DateField03: return DateField03.ToString("MM/dd/yyyy"); break;
                case EnumCIBFields.DateField04: return DateField04.ToString("MM/dd/yyyy"); break;
                case EnumCIBFields.DateField05: return DateField05.ToString("MM/dd/yyyy"); break;

                case EnumCIBFields.TextField01: return TextField01; break;
                case EnumCIBFields.TextField02: return TextField02; break;
                case EnumCIBFields.TextField03: return TextField03; break;
                case EnumCIBFields.TextField04: return TextField04; break;
                case EnumCIBFields.TextField05: return TextField05; break;
                case EnumCIBFields.TextField06: return TextField06; break;
                case EnumCIBFields.TextField07: return TextField07; break;
                case EnumCIBFields.TextField08: return TextField08; break;
                case EnumCIBFields.TextField09: return TextField09; break;
                case EnumCIBFields.TextField10: return TextField10; break;
                case EnumCIBFields.TextField11: return TextField11; break;
                case EnumCIBFields.TextField12: return TextField12; break;
                case EnumCIBFields.TextField13: return TextField13; break;
                case EnumCIBFields.TextField14: return TextField14; break;
                case EnumCIBFields.TextField15: return TextField15; break;
                default: 
                    return "Undetermined#1"; 
                    break;
            }
            return "Undetermined";
        }

        //
        //Addeed 10/4/2019 thomas downes  
        //
        public DateTime GetDateValue(EnumCIBFields par_enum)
        {
            switch (par_enum)
            {
                case EnumCIBFields.DateField01: return DateField01; //break;
                case EnumCIBFields.DateField02: return DateField02; //break;
                case EnumCIBFields.DateField03: return DateField03; //break;
                case EnumCIBFields.DateField04: return DateField04; //break;
                case EnumCIBFields.DateField05: return DateField05; //break;
            }
            return DateTime.MinValue;
        }

    }
}



