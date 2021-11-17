using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ciBadgeFields;  //Added 11/16/2021 thomas downes
using AutoMapper;  // Added 11/17/2021 thomas downes

namespace ciBadgeForWeb.Models
{
    public class Field : ciBadgeFields.ClassFieldAny
    {
        //
        // Added 11/16/2021 thomas downes 
        //
        public static List<Field> ListOfFields_CreateCopies(HashSet<ClassFieldStandard> par_HashOfFields_Standard,
                                                            HashSet<ClassFieldCustomized> par_HashOfFields_Custom) // As List(Of ClassFieldAny)
        {
            //''
            //''Added 11/15/2021 thomas downes
            //''
            //''Create copies of the Field objects.
            //''
            //Dim obj_list As New List(Of ClassFieldAny)
            var obj_list = new List<Field>();

            foreach (ClassFieldStandard each_fld in par_HashOfFields_Standard)
            {
                //Make a copy. 
                //---obj_list.Add((Field)each_fld.Copy());
                //---=-obj_list.Add(new Field(each_fld));
                obj_list.Add(Field.CopyToField(each_fld));
            }

            foreach (ClassFieldCustomized each_fld in par_HashOfFields_Custom)
            {
                //Make a copy. 
                //----obj_list.Add((Field)each_fld.Copy());
                obj_list.Add(Field.CopyToField(each_fld));
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


        public static List<ciBadgeFields.ClassFieldAny> ConvertListItems(List<Field> par_list)
        {
            //
            // Added 11/17/2021 thomas downes
            //
            var output_list = new List<ciBadgeFields.ClassFieldAny>();

            foreach (Field each_field in par_list)
            {
                output_list.Add((ClassFieldAny)each_field);
            }
            return output_list;

        }


        public static Models.Field CopyToField(ciBadgeFields.ClassFieldAny par_field)
        {
            //
            //Added 11/17/2021 thomas d. 
            //
            // https://stackoverflow.com/questions/16534253/c-sharp-converting-base-class-to-child-class
            //
            //base.CIBadgeField = par_field.CIBadgeField;
            //base.CurrentRecipValue = par_field.CurrentRecipValue;
            ////base.CurrentRecipValue_AllowEgs = par_field.CurrentRecipValue_AllowEgs;
            //base.CurrentRecipValue_Date = par_field.CurrentRecipValue_Date;
            //base.DataEntryText = par_field.DataEntryText;
            //base.DefaultValue = par_field.DefaultValue;
            //base.ExampleValue = par_field.ExampleValue;

            // https://stackoverflow.com/questions/16534253/c-sharp-converting-base-class-to-child-class
            // now we want to type-cast, but we can't, so we instantiate using AutoMapper
            //  http://automapper.org/
            //AutoMapper.Mapper.CreateMap<NetworkClient, SkyfilterClient>();
            //AutoMapper.Mappers.

            //Using automapper. https://dotnettutorials.net/lesson/automapper-in-c-sharp/
            var mapper = new Mapper(App_Start.FieldMapper.GetMapperConfiguration());
            var new_field = mapper.Map<Field>(par_field);
            return new_field;

        }





    }
}