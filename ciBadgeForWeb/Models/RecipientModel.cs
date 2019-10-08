using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ciBadgeInterfaces;  //Added 10/6/2019 td 
using ciBadgeFields;  //Added 10/6/2019 td
//
//Added 10/6/2019 thomas d. 
//


namespace ciBadgeForWeb.Models
{
    public class RecipientModel
    {
        //
        //Added 10/6/2019 thomas d. 
        //
        public RecipientModel(IRecipient par_recip, List<ClassFieldAny> par_fields)
        {
            //ClassFieldAny each_field;

            foreach(ClassFieldAny each_field in par_fields)
            {
                switch (each_field.FieldEnumValue)
                {
                    case EnumCIBFields.fstrID:
                        ID = par_recip.RecipientID();
                        ID_Show = true;
                        break;
                    case EnumCIBFields.fstrLastName:
                        LastNm = par_recip.fstrLastName;
                        LastNm_Label = each_field.FieldLabelCaption;
                        LastNm_Edit = each_field.IsDisplayedForEdits;
                        LastNm_Show = true;
                        break;
                    case EnumCIBFields.fstrFirstName:
                        FirstNm = par_recip.fstrFirstName;
                        FirstNm_Label = each_field.FieldLabelCaption;
                        FirstNm_Edit = each_field.IsDisplayedForEdits;
                        FirstNm_Show = true;
                        break;
                    case EnumCIBFields.fstrMidName:
                        MiddleNm = par_recip.fstrMidName;
                        MiddleNm_Label = each_field.FieldLabelCaption;
                        MiddleNm_Edit = each_field.IsDisplayedForEdits;
                        MiddleNm_Show = true;
                        break;



                }



            }




        }

        public string ID { get; set; }
        public string ID_Label { get; set; }
        public bool ID_Edit { get; set; }
        public bool ID_Show { get; set; }

        public string LastNm { get; set; }
        public string LastNm_Label { get; set; }
        public bool LastNm_Edit { get; set; }
        public bool LastNm_Show { get; set; }

        public string FirstNm { get; set; }
        public string FirstNm_Label { get; set; }
        public bool FirstNm_Edit { get; set; }
        public bool FirstNm_Show { get; set; }

        public string MiddleNm { get; set; }
        public string MiddleNm_Label { get; set; }
        public bool MiddleNm_Edit { get; set; }
        public bool MiddleNm_Show { get; set; }









    }
}