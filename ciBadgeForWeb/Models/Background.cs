using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing; // Added 7/6/2019 thomas downes
 
namespace ciBadgeForWeb.Models
{
    public class Background
    {
        //Added 11/2/2021 thomas downes
        public static int CurrentlySelectedBackIndex
        {
            //Added 11/2/2021 thomas downes
            get; set;
        }


        public static string Get_FileTitle()
        {
            // Added 11/2/2021 tdownes
            //
            var obj_back = Controllers.UploadBackController.mod_backgrounds[CurrentlySelectedBackIndex];
            return obj_back.FileName;

        }

        
        public static string Get_FullPath()
        {
            // Added 11/2/2021 tdownes
            var obj_back = Controllers.UploadBackController.mod_backgrounds[CurrentlySelectedBackIndex];
            return obj_back.FullPathToFile;

        }


        public int Index
        {
            get; set;
        }

        public string Guid6Chars
        {
            //
            // Added 11/2/2021 Thomas Downes 
            //
            get; set;
        }

        public string FileName { get; set; }

        public Image BackgroundImage { get; set; }

        public string Description { get; set; }

        public string FullPathToFile { get; set; }

        public DateTime UploadDate { get; set; }

        //Added 11/2/2021 thomas downes 
        public bool IsSelectedForBadge { get; set; }

        //Added 11/2/2021 thomas downes 
        //   Indicate that a background is Deprecated
        //   and should not be displayed in "Select a Background"
        //   lists. ----11/2/2021 thomas downes
        public bool IsSuppressedFromSelection { get; set; }

    }
}