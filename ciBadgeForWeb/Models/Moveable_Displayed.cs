using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciBadgeForWeb.Models
{
    public class Moveable_Displayed
    {

        public bool EL1_Displayed { get; set; }
        public bool EL2_Displayed { get; set; }
        public bool EL3_Displayed { get; set; }
        public bool EL4_Displayed { get; set; }
        public bool EL5_Displayed { get; set; }
        public bool EL6_Displayed { get; set; }
        public bool EL7_Displayed { get; set; }
        public bool EL8_Displayed { get; set; }
        public bool EL9_Displayed { get; set; }
        public bool EL10_Displayed { get; set; }
        public bool EL11_Displayed { get; set; }
        public bool EL12_Displayed { get; set; }

        //There is a gap between the 12(+1 for 0th) Standard fields being
        //   possibly displayed, and the five customizable fields.)
        public bool EL15_Displayed { get; set; }
        public bool EL16_Displayed { get; set; }
        public bool EL17_Displayed { get; set; }
        public bool EL18_Displayed { get; set; }
        public bool EL19_Displayed { get; set; }



        public bool this[int i]
        {
            get
            {
                if (i == 1) return this.EL1_Displayed;
                if (i == 2) return this.EL2_Displayed;
                if (i == 3) return this.EL3_Displayed;
                if (i == 4) return this.EL4_Displayed;
                if (i == 5) return this.EL5_Displayed;
                if (i == 6) return this.EL6_Displayed;
                if (i == 7) return this.EL7_Displayed;
                if (i == 8) return this.EL8_Displayed;
                if (i == 9) return this.EL9_Displayed;
                if (i == 10) return this.EL10_Displayed;
                if (i == 11) return this.EL11_Displayed;
                if (i == 12) return this.EL12_Displayed;

                //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields.)
                if (i == 15) return this.EL15_Displayed;
                if (i == 16) return this.EL16_Displayed;
                if (i == 17) return this.EL17_Displayed;
                if (i == 18) return this.EL18_Displayed;
                if (i == 19) return this.EL19_Displayed;

                else return false;  // 1655; // "sdfg";
            }
            set
            {
                if (i == 1) this.EL1_Displayed = value;
                if (i == 2) this.EL2_Displayed = value;
                if (i == 3) this.EL3_Displayed = value;
                if (i == 4) this.EL4_Displayed = value;
                if (i == 5) this.EL5_Displayed = value;
                if (i == 6) this.EL6_Displayed = value;
                if (i == 7) this.EL7_Displayed = value;
                if (i == 8) this.EL8_Displayed = value;
                if (i == 9) this.EL9_Displayed = value;
                if (i == 10) this.EL10_Displayed = value;
                if (i == 11) this.EL11_Displayed = value;
                if (i == 12) this.EL12_Displayed = value;

                //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields.)
                if (i == 15) this.EL15_Displayed = value;
                if (i == 16) this.EL16_Displayed = value;
                if (i == 17) this.EL17_Displayed = value;
                if (i == 18) this.EL18_Displayed = value;
                if (i == 19) this.EL19_Displayed = value;

                //else ;
            }
        }

    }
}