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
        private static MapperConfiguration _configuration;

        public static MapperConfiguration GetMapperConfiguration()
        {
            //
            // Added 11/17/2021 td
            //
            if (_configuration != null) return _configuration;

            // https://docs.automapper.org/en/latest/Setup.html
            //_configuration = new MapperConfiguration(cfg => {
            //    cfg.AddProfile<AppProfile>();
            //    cfg.CreateMap<ciBadgeFields.ClassFieldAny, Models.Field>();
            //});

            // https://dotnettutorials.net/lesson/automapper-in-c-sharp/
            _configuration = new MapperConfiguration(cfg => {
                cfg.CreateMap<ciBadgeFields.ClassFieldAny, Models.Field>();
            });

            return _configuration;

        }


    }
}