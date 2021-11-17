using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ciBadgeFields;  //Added 11/16/2021 thomas downes

namespace ciBadgeForWeb.Models
{
    public class Field : ciBadgeFields.ClassFieldAny
    {
        //
        // Added 11/16/2021 thomas downes 
        //
        public static List<Field> ListOfFields_CreateCopies(List<ClassFieldStandard> par_ListOfFields_Standard,
                                                            List<ClassFieldCustomized> par_ListOfFields_Custom) // As List(Of ClassFieldAny)
        {
            //''
            //''Added 11/15/2021 thomas downes
            //''
            //''Create copies of the Field objects.
            //''
            //Dim obj_list As New List(Of ClassFieldAny)
            var obj_list = new List<Field>();

            foreach (ClassFieldStandard each_fld in par_ListOfFields_Standard)
            {
                //Make a copy. 
                obj_list.Add((Field)each_fld.Copy());
            }

            foreach (ClassFieldCustomized each_fld in par_ListOfFields_Custom)
            {
                //Make a copy. 
                obj_list.Add((Field)each_fld.Copy());
            }

            //''11/15/2021 td'' obj_list.AddRange(ListOfFields_Standard)
            //For Each objFieldS As ClassFieldStandard In ListOfFields_Standard
            //    ''Make a copy.
            //    obj_list.Add(objFieldS.Copy())
            //Next objFieldS

            //''11/15/2021 td'' obj_list.AddRange(ListOfFields_Custom)
            //For Each objFieldC As ClassFieldCustomized In ListOfFields_Custom
            //    ''Make a copy.
            //    obj_list.Add(objFieldC.Copy())
            //Next objFieldC

            return obj_list;

            //End Function ''End of "Public Function ListOfFields_Any() As List(Of ClassFieldAny)"
        }



    }
}