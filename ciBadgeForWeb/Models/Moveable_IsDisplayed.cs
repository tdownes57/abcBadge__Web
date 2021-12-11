using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciBadgeForWeb.Models
{
    public class Moveable_IsDisplayed  //Dec.11 2021 //class Moveable_Displayed
    {
        //---Dec. 11, 2021 -----public class Moveable_Displayed
        //
        //  This would be a Boolean value, except maybe because it's JSON data
        //  it needs to be a string? 
        //
        //  Oh, never mind, it IS a Boolean value. ----12/11/2021 thomas downes
        //

        public bool EL1_IsDisplayed { get; set; }
        public bool EL2_IsDisplayed { get; set; }
        public bool EL3_IsDisplayed { get; set; }
        public bool EL4_IsDisplayed { get; set; }
        public bool EL5_IsDisplayed { get; set; }
        public bool EL6_IsDisplayed { get; set; }
        public bool EL7_IsDisplayed { get; set; }
        public bool EL8_IsDisplayed { get; set; }
        public bool EL9_IsDisplayed { get; set; }
        public bool EL10_IsDisplayed { get; set; }
        public bool EL11_IsDisplayed { get; set; }
        public bool EL12_IsDisplayed { get; set; }

        //There is a gap between the 12(+1 for 0th) Standard fields being
        //   possibly displayed, and the five customizable fields.)
        public bool EL15_IsDisplayed { get; set; }
        public bool EL16_IsDisplayed { get; set; }
        public bool EL17_IsDisplayed { get; set; }
        public bool EL18_IsDisplayed { get; set; }
        public bool EL19_IsDisplayed { get; set; }



        public bool this[int i]
        {
            get
            {
                if (i == 1) return this.EL1_IsDisplayed;
                if (i == 2) return this.EL2_IsDisplayed;
                if (i == 3) return this.EL3_IsDisplayed;
                if (i == 4) return this.EL4_IsDisplayed;
                if (i == 5) return this.EL5_IsDisplayed;
                if (i == 6) return this.EL6_IsDisplayed;
                if (i == 7) return this.EL7_IsDisplayed;
                if (i == 8) return this.EL8_IsDisplayed;
                if (i == 9) return this.EL9_IsDisplayed;
                if (i == 10) return this.EL10_IsDisplayed;
                if (i == 11) return this.EL11_IsDisplayed;
                if (i == 12) return this.EL12_IsDisplayed;

                //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields.)
                if (i == 15) return this.EL15_IsDisplayed;
                if (i == 16) return this.EL16_IsDisplayed;
                if (i == 17) return this.EL17_IsDisplayed;
                if (i == 18) return this.EL18_IsDisplayed;
                if (i == 19) return this.EL19_IsDisplayed;

                else return false;  // 1655; // "sdfg";
            }
            set
            {
                if (i == 1) this.EL1_IsDisplayed = value;
                if (i == 2) this.EL2_IsDisplayed = value;
                if (i == 3) this.EL3_IsDisplayed = value;
                if (i == 4) this.EL4_IsDisplayed = value;
                if (i == 5) this.EL5_IsDisplayed = value;
                if (i == 6) this.EL6_IsDisplayed = value;
                if (i == 7) this.EL7_IsDisplayed = value;
                if (i == 8) this.EL8_IsDisplayed = value;
                if (i == 9) this.EL9_IsDisplayed = value;
                if (i == 10) this.EL10_IsDisplayed = value;
                if (i == 11) this.EL11_IsDisplayed = value;
                if (i == 12) this.EL12_IsDisplayed = value;

                //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields.)
                if (i == 15) this.EL15_IsDisplayed = value;
                if (i == 16) this.EL16_IsDisplayed = value;
                if (i == 17) this.EL17_IsDisplayed = value;
                if (i == 18) this.EL18_IsDisplayed = value;
                if (i == 19) this.EL19_IsDisplayed = value;

                //else ;
            }
        }

    }
}