using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing; // Added 7/6/2019 thomas downes
 
namespace ciBadgeForWeb.Models
{
    public class Background
    {
        public int Index
        {
            get; set;
        }

        public string FileName { get; set; }

        public Image BackgroundImage { get; set; }

        public string Description { get; set; }

        public string FullPathToFile { get; set; }

        public DateTime UploadDate { get; set; }

    }
}