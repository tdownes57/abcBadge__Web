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
                //else ;
            }
        }

    }
}