using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciBadgeForWeb.Models
{
    //
    //  https://www.c-sharpcorner.com/uploadfile/dhananjaycoder/working-with-images-in-Asp-Net-mvc-framework/
    //
    public class PortraitImage
    {
        //
        //  https://www.c-sharpcorner.com/uploadfile/dhananjaycoder/working-with-images-in-Asp-Net-mvc-framework/
        //

        public PortraitImage(string path, string desc)
        {
            Path = path;
            Description = desc;

        }

        public string Path { get; set; }
        public string Description { get; set; }


    }
}