using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciBadgeForWeb.Models
{
    public class Moveable_HasField
    {

        public bool EL1_HasField { get; set; }
        public bool EL2_HasField { get; set; }
        public bool EL3_HasField { get; set; }
        public bool EL4_HasField { get; set; }
        public bool EL5_HasField { get; set; }
        public bool EL6_HasField { get; set; }
        public bool EL7_HasField { get; set; }
        public bool EL8_HasField { get; set; }
        public bool EL9_HasField { get; set; }
        public bool EL10_HasField { get; set; }
        public bool EL11_HasField { get; set; }
        public bool EL12_HasField { get; set; }

        public bool this[int i]
        {
            get
            {
                if (i == 1) return this.EL1_HasField;
                if (i == 2) return this.EL2_HasField;
                if (i == 3) return this.EL3_HasField;
                if (i == 4) return this.EL4_HasField;
                if (i == 5) return this.EL5_HasField;
                if (i == 6) return this.EL6_HasField;
                if (i == 7) return this.EL7_HasField;
                if (i == 8) return this.EL8_HasField;
                if (i == 9) return this.EL9_HasField;
                if (i == 10) return this.EL10_HasField;
                if (i == 11) return this.EL11_HasField;
                if (i == 12) return this.EL12_HasField;
                else return false; // "sdfg";
            }
            set
            {
                if (i == 1) this.EL1_HasField = value;
                if (i == 2) this.EL2_HasField = value;
                if (i == 3) this.EL3_HasField = value;
                if (i == 4) this.EL4_HasField = value;
                if (i == 5) this.EL5_HasField = value;
                if (i == 6) this.EL6_HasField = value;
                if (i == 7) this.EL7_HasField = value;
                if (i == 8) this.EL8_HasField = value;
                if (i == 9) this.EL9_HasField = value;
                if (i == 10) this.EL10_HasField = value;
                if (i == 11) this.EL11_HasField = value;
                if (i == 12) this.EL12_HasField = value;
                //else ;
            }
        }

    }
}