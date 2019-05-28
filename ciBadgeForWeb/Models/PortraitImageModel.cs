using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Drawing;   //Added 5/27/2019 td

namespace ciBadgeForWeb.Models
{
    //
    //  https://www.c-sharpcorner.com/uploadfile/dhananjaycoder/working-with-images-in-Asp-Net-mvc-framework/
    //
    public class PortraitImageModel: List<PortraitImage>
    {
        //
        //  https://www.c-sharpcorner.com/uploadfile/dhananjaycoder/working-with-images-in-Asp-Net-mvc-framework/
        //

        public PortraitImageModel()
        {
            string directoryOfImage = HttpContext.Current.Server.MapPath("~/Images/");
            XDocument imageData = XDocument.Load(directoryOfImage + @"/ImageMetaData.xml");
            var images = from image in imageData.Descendants("image") select new PortraitImage(image.Element("filename").Value, image.Element("description").Value);
            this.AddRange(images.ToList<PortraitImage>());
        }

    }
}