using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;  //Added 11/17/2021 td  

namespace ciBadgeForWeb.App_Start
{
    public class FieldMapper
    {
        //
        //   Added 11/17/2021 td 
        //
        //   https://stackoverflow.com/questions/16534253/c-sharp-converting-base-class-to-child-class
        //   https://dotnettutorials.net/lesson/automapper-in-c-sharp/
        //   https://docs.automapper.org/en/latest/Setup.html
        //
        private static MapperConfiguration _configurationAny;
        // Added 11/17/2021 td
        private static MapperConfiguration _configurationStandard;
        private static MapperConfiguration _configurationCustom;
        // Added 11/17/2021 td
        private static MapperConfiguration _configReverseStandard;
        private static MapperConfiguration _configReverseCustom;

        public static MapperConfiguration GetMapperConfigAny()
        {
            //---public static MapperConfiguration GetMapperConfiguration()
            //
            // Added 11/17/2021 td
            //
            if (_configurationAny != null) return _configurationAny;

            // https://docs.automapper.org/en/latest/Setup.html
            //_configuration = new MapperConfiguration(cfg => {
            //    cfg.AddProfile<AppProfile>();
            //    cfg.CreateMap<ciBadgeFields.ClassFieldAny, Models.Field>();
            //});

            // https://dotnettutorials.net/lesson/automapper-in-c-sharp/
            _configurationAny = new MapperConfiguration(cfg => {
                cfg.CreateMap<ciBadgeFields.ClassFieldAny, Models.Field>();
            });

            return _configurationAny;

        }


        public static MapperConfiguration GetMapperConfigStandard()
        {
            //
            // Added 11/17/2021 td
            //
            if (_configurationStandard != null) return _configurationStandard;

            // https://docs.automapper.org/en/latest/Setup.html
            //_configuration = new MapperConfiguration(cfg => {
            //    cfg.AddProfile<AppProfile>();
            //    cfg.CreateMap<ciBadgeFields.ClassFieldAny, Models.Field>();
            //});

            // https://dotnettutorials.net/lesson/automapper-in-c-sharp/
            _configurationStandard = new MapperConfiguration(cfg => {
                cfg.CreateMap<ciBadgeFields.ClassFieldStandard, Models.Field>();
            });

            return _configurationStandard;

        }

        public static MapperConfiguration GetMapperConfigStandard_Reverse()
        {
            //
            // Added 11/17/2021 td
            //
            if (_configReverseStandard != null) return _configReverseStandard;

            //This is the opposite of _configurationStandard, insofar
            //    as the mapping (of field values) flows in the opposite direction. ---td
            //
            _configReverseStandard = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.Field, ciBadgeFields.ClassFieldStandard>();
            });
            return _configReverseStandard;
        }

        public static MapperConfiguration GetMapperConfigCustom()
        {
            //
            // Added 11/17/2021 td
            //
            if (_configurationCustom != null) return _configurationCustom;

            // https://docs.automapper.org/en/latest/Setup.html
            //_configuration = new MapperConfiguration(cfg => {
            //    cfg.AddProfile<AppProfile>();
            //    cfg.CreateMap<ciBadgeFields.ClassFieldAny, Models.Field>();
            //});

            // https://dotnettutorials.net/lesson/automapper-in-c-sharp/
            _configurationCustom = new MapperConfiguration(cfg => {
                cfg.CreateMap<ciBadgeFields.ClassFieldCustomized, Models.Field>();
            });

            return _configurationCustom;

        }


        public static MapperConfiguration GetMapperConfigCustom_Reverse()
        {
            //
            // Added 11/17/2021 td
            //
            if (_configReverseCustom != null) return _configReverseCustom;

            //This is the opposite of _configurationCustom, insofar
            //    as the mapping (of field values) flows in the opposite direction. ---td
            //
            _configReverseCustom = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.Field, ciBadgeFields.ClassFieldCustomized>();
            });
            return _configReverseStandard;
        }


    }
}