using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing; // Added 7/6/2019 thomas downes
 
namespace ciBadgeForWeb.Models
{
    public class Background
    {
        private static Dictionary<string, int> mod_dictionaryOfBackIndices;
        private static int _currentlySelectedBackIndex = -1; // Added 11/10/2021   

        //Added 11/2/2021 thomas downes
        public static int CurrentlySelectedBackIndex
        {
            //Added 11/2/2021 thomas downes
            //get; set;
            //get { return _currentlySelectedBackIndex; }
            get => _currentlySelectedBackIndex;
            set =>  _currentlySelectedBackIndex = value; 
        }


        public static void SetCurrentIndex(int par_newIndex)
        {
            // Added 11/4/2021 thomas downes
            CurrentlySelectedBackIndex = par_newIndex;
        }


        public static bool IsSelected(int par_newIndex)
        {
            // Added 11/07/2021 thomas downes
            return (par_newIndex == CurrentlySelectedBackIndex);
        }


        //Added 11/2/2021 thomas downes
        public static int UsedIndexByConfigGuid6(string par_guid6Config)
        {
            //Added 11/2/2021 thomas downes
            //
            //  This returns the integral index which tells Step4Handler which background image 
            //    to use in generating the Badges for the relevant Personality Configuration. 
            //
            //   The prefix "guid6" (in "par_guid6Config") means a random-generated 6-character Guid.
            //
            return mod_dictionaryOfBackIndices[par_guid6Config];

        }


        //Added 11/04/2021 thomas downes
        public static int CurrentIndex_RunChecks()
        {
            //Added 11/2/2021 thomas downes

            //Added 11/04/2021 thomas downes
            if (0 == Controllers.BackgroundController.mod_backgrounds.Count())
            {
                Controllers.BackgroundController.RefreshBackgroundList();
                _currentlySelectedBackIndex = Controllers.BackgroundController.GetHighestIndex();
            }

            //Added 11/10/2021 td
            //  Initialize the value to an actual value. 
            else if (_currentlySelectedBackIndex == -1)
            {  
                _currentlySelectedBackIndex = Controllers.BackgroundController.GetHighestIndex(); 
            }

            //Added 11/2/2021 thomas downes
            return _currentlySelectedBackIndex;
        }


        public static Background GetCurrentBackground()
        {
            //
            // Added 11/04/2021 tdownes
            //
            int intCurrentIndex = CurrentIndex_RunChecks();

            var obj_back_list = Controllers.BackgroundController
                .mod_backgrounds
                .Where<Background>(s => s.Index == intCurrentIndex);

            return obj_back_list.FirstOrDefault();

        }


        public static string Get_FileTitle(string pstrConfig_Guid6 = "")
        {
            // Added 11/2/2021 tdownes
            //
            //   The suffix "_Guid6" in "pstrConfig_Guid6" means a random-generated 6-char Guid.
            //
            //---var obj_back = Controllers.BackgroundController.mod_backgrounds[CurrentlySelectedBackIndex];

            // Added 11/4/2021 thomas downes
            //--//int intCurrentIndex = CurrentIndex_RunChecks();

            //--//var obj_back_list = Controllers.BackgroundController
            //--//    .mod_backgrounds
            //--//    .Where<Background>(s => s.Index == intCurrentIndex);

            //if (0 == obj_back_list.Count())
            //{
            //    CurrentlySelectedBackIndex = Background.GetHighestIndex();
            //}

            //--//return obj_back_list.FirstOrDefault().FileName;

            return GetCurrentBackground().FileName;  
        }

        
        public static string Get_FullPath(string pstrConfig_Guid6 = "")
        {
            // Added 11/2/2021 tdownes
            //--var obj_back = Controllers.BackgroundController.mod_backgrounds[CurrentlySelectedBackIndex];
            //--return obj_back.FullPathToFile;
            return GetCurrentBackground().FullPathToFile;

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