//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

namespace ciBadgeForWeb.Models
{
    public class Moveable_IsRotated90
    {
        //
        // Added 12/11/2021 Thomas C. Downes 
        //

        public bool EL1_IsRotated90 { get; set; }
        public bool EL2_IsRotated90 { get; set; }
        public bool EL3_IsRotated90 { get; set; }
        public bool EL4_IsRotated90 { get; set; }
        public bool EL5_IsRotated90 { get; set; }
        public bool EL6_IsRotated90 { get; set; }
        public bool EL7_IsRotated90 { get; set; }
        public bool EL8_IsRotated90 { get; set; }
        public bool EL9_IsRotated90 { get; set; }
        public bool EL10_IsRotated90 { get; set; }
        public bool EL11_IsRotated90 { get; set; }
        public bool EL12_IsRotated90 { get; set; }

        //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields.)
        public bool EL15_IsRotated90 { get; set; }
        public bool EL16_IsRotated90 { get; set; }
        public bool EL17_IsRotated90 { get; set; }
        public bool EL18_IsRotated90 { get; set; }
        public bool EL19_IsRotated90 { get; set; }



        public bool this[int i]
        {
            get
            {
                if (i == 1) return this.EL1_IsRotated90;
                if (i == 2) return this.EL2_IsRotated90;
                if (i == 3) return this.EL3_IsRotated90;
                if (i == 4) return this.EL4_IsRotated90;
                if (i == 5) return this.EL5_IsRotated90;
                if (i == 6) return this.EL6_IsRotated90;
                if (i == 7) return this.EL7_IsRotated90;
                if (i == 8) return this.EL8_IsRotated90;
                if (i == 9) return this.EL9_IsRotated90;
                if (i == 10) return this.EL10_IsRotated90;
                if (i == 11) return this.EL11_IsRotated90;
                if (i == 12) return this.EL12_IsRotated90;

                //There is a gap between the 12(+1 for 0th) Standard fields being
                //  possibly displayed, and the five customizable fields.)
                if (i == 15) return this.EL15_IsRotated90;
                if (i == 16) return this.EL16_IsRotated90;
                if (i == 17) return this.EL17_IsRotated90;
                if (i == 18) return this.EL18_IsRotated90;
                if (i == 19) return this.EL19_IsRotated90;
                else return false; // "sdfg";
            }
            set
            {
                if (i == 1) this.EL1_IsRotated90 = value;
                if (i == 2) this.EL2_IsRotated90 = value;
                if (i == 3) this.EL3_IsRotated90 = value;
                if (i == 4) this.EL4_IsRotated90 = value;
                if (i == 5) this.EL5_IsRotated90 = value;
                if (i == 6) this.EL6_IsRotated90 = value;
                if (i == 7) this.EL7_IsRotated90 = value;
                if (i == 8) this.EL8_IsRotated90 = value;
                if (i == 9) this.EL9_IsRotated90 = value;
                if (i == 10) this.EL10_IsRotated90 = value;
                if (i == 11) this.EL11_IsRotated90 = value;
                if (i == 12) this.EL12_IsRotated90 = value;

                //There is a gap between the 12(+1 for 0th) Standard fields being
                //  possibly displayed, and the five customizable fields.)
                if (i == 15) this.EL15_IsRotated90 = value;
                if (i == 16) this.EL16_IsRotated90 = value;
                if (i == 17) this.EL17_IsRotated90 = value;
                if (i == 18) this.EL18_IsRotated90 = value;
                if (i == 19) this.EL19_IsRotated90 = value;
                //else ;
            }
        }

    }
}