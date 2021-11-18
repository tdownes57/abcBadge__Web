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
        public string[] BugMessages = new string[12 + 1]; // Added 11/17/2021 td

        public static List<Field> ListOfFields_CreateCopies(HashSet<ClassFieldStandard> par_HashOfFields_Standard,
                                                            HashSet<ClassFieldCustomized> par_HashOfFields_Custom,
                                                            ref List<Field> ref_listStandard,
                                                            ref List<Field> ref_listCustom) // As List(Of ClassFieldAny)
        {
            //''
            //''Added 11/15/2021 thomas downes
            //''
            //''Create copies of the Field objects.
            //''
            //Dim obj_list As New List(Of ClassFieldAny)
            var obj_listAny = new List<Field>();

            //Added 11/17/2021 td
            ref_listStandard.Clear();
            ref_listCustom.Clear();

            foreach (ClassFieldStandard each_fld in par_HashOfFields_Standard)
            {
                //Make a copy. 
                //---obj_list.Add((Field)each_fld.Copy());
                //---=-obj_list.Add(new Field(each_fld));
                //---===obj_list.Add(Field.CopyToField(each_fld));
                //====obj_listAny.Add(Field.CopyToField_Standard(each_fld));
                var each_standard = Field.CopyToField_Standard(each_fld);
                obj_listAny.Add(each_standard);
                ref_listStandard.Add(each_standard);

            }

            foreach (ClassFieldCustomized each_fldCustom in par_HashOfFields_Custom)
            {
                //Make a copy. 
                //----obj_list.Add((Field)each_fld.Copy());
                //---===obj_list.Add(Field.CopyToField(each_fld));
                //====obj_listAny.Add(Field.CopyToField_Custom(each_fld));
                var each_customField = Field.CopyToField_Custom(each_fldCustom);
                obj_listAny.Add(each_customField);
                ref_listCustom.Add(each_customField);

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

            return obj_listAny;

            //End Function ''End of "Public Function ListOfFields_Any() As List(Of ClassFieldAny)"
        }


        public static List<ciBadgeFields.ClassFieldAny> ConvertListItems_Deprecated(List<Field> par_list)
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


        public static void ConvertListItems(List<Field> par_list, 
                   ref List<ClassFieldStandard> par_listStandard,
                   ref List<ClassFieldCustomized> par_listCustom)
        {
            //
            // Added 11/17/2021 thomas downes
            //
            //var output_list = new List<ciBadgeFields.ClassFieldAny>();

            foreach (Field each_field in par_list)
            {
                //output_list.Add((ClassFieldAny)each_field);
                if (each_field.IsCustomizable) 
                    par_listCustom.Add(Field.CopyToField_Custom(each_field));
                else par_listStandard.Add(Field.CopyToField_Standard(each_field));
            }
            //return output_list;

        }


        public static Models.Field CopyToField_Any(ciBadgeFields.ClassFieldAny par_field)
        {
            //public static Models.Field CopyToField(ciBadgeFields.ClassFieldAny par_field)
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

            //
            //   https://stackoverflow.com/questions/16534253/c-sharp-converting-base-class-to-child-class
            //   https://dotnettutorials.net/lesson/automapper-in-c-sharp/
            //   https://docs.automapper.org/en/latest/Setup.html
            //
            // https://stackoverflow.com/questions/16534253/c-sharp-converting-base-class-to-child-class
            // now we want to type-cast, but we can't, so we instantiate using AutoMapper
            //  http://automapper.org/
            //AutoMapper.Mapper.CreateMap<NetworkClient, SkyfilterClient>();
            //AutoMapper.Mappers.

            //Using automapper. https://dotnettutorials.net/lesson/automapper-in-c-sharp/
            //-----var mapper = new Mapper(App_Start.FieldMapper.GetMapperConfiguration());
            var mapper = new Mapper(App_Start.FieldMapper.GetMapperConfigAny());
            var new_field = mapper.Map<Field>(par_field);
            return new_field;

        }


        public static Models.Field CopyToField_Standard(ciBadgeFields.ClassFieldStandard par_field)
        {
            //
            //Added 11/17/2021 thomas d. 
            //
            //Using automapper. https://dotnettutorials.net/lesson/automapper-in-c-sharp/
            //--var mapper = new Mapper(App_Start.FieldMapper.GetMapperConfiguration());
            var mapper = new Mapper(App_Start.FieldMapper.GetMapperConfigStandard());
            var new_field = mapper.Map<Field>(par_field);
            new_field.IsCustomizable = (false == true);
            return new_field;

        }


        public static ClassFieldStandard CopyToField_Standard(Models.Field par_field)
        {
            //
            //Added 11/17/2021 thomas d. 
            //
            //Using automapper. https://dotnettutorials.net/lesson/automapper-in-c-sharp/
            //--var mapper = new Mapper(App_Start.FieldMapper.GetMapperConfiguration());
            var mapper = new Mapper(App_Start.FieldMapper.GetMapperConfigStandard_Reverse());
            var new_field = mapper.Map<ciBadgeFields.ClassFieldStandard>(par_field);
            new_field.IsCustomizable = (false == true);
            return new_field;

        }


        public static Field CopyToField_Custom(ciBadgeFields.ClassFieldCustomized par_field)
        {
            //
            //Added 11/17/2021 thomas d. 
            //
            //Using automapper. https://dotnettutorials.net/lesson/automapper-in-c-sharp/
            var mapper = new Mapper(App_Start.FieldMapper.GetMapperConfigCustom());
            var new_field = mapper.Map<Field>(par_field);
            new_field.IsCustomizable = true;
            return new_field;

        }


        public static ClassFieldCustomized CopyToField_Custom(Field par_field)
        {
            //
            //Added 11/17/2021 thomas d. 
            //
            //Using automapper. https://dotnettutorials.net/lesson/automapper-in-c-sharp/
            //
            var mapper = new Mapper(App_Start.FieldMapper.GetMapperConfigCustom_Reverse());
            var new_field = mapper.Map<ciBadgeFields.ClassFieldCustomized>(par_field);
            //new_field.IsCustomizable = true;
            return new_field;

        }


        //private Field()
        //{
        //    //
        //    // Don't allow this parameterless constructor to be used. ----11/17/2021 td
        //    //
        //}

        public bool IsCustomized_Deprecated;

        //public Field(ciBadgeFields.ClassFieldCustomized par_fieldCustom)
        //{
        //    //
        //    // Use AutoMapper configuration. ----11/17/2021 td
        //    //


        //}



        //public bool IsCustomized()
        //{
        //    //
        //    // Added 11/17/2021 td
        //    //
        //    throw new NotImplementedException();

        //}



    }
}