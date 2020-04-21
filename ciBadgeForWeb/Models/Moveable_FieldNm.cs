using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciBadgeForWeb.Models
{
    public class Moveable_FieldNm
    {

        public string EL1_FieldNm { get; set; }
        public string EL2_FieldNm { get; set; }
        public string EL3_FieldNm { get; set; }
        public string EL4_FieldNm { get; set; }
        public string EL5_FieldNm { get; set; }
        public string EL6_FieldNm { get; set; }
        public string EL7_FieldNm { get; set; }
        public string EL8_FieldNm { get; set; }
        public string EL9_FieldNm { get; set; }
        public string EL10_FieldNm { get; set; }
        public string EL11_FieldNm { get; set; }
        public string EL12_FieldNm { get; set; }

        public string this[int i]
        {
            get
            {
                if (i == 1) return this.EL1_FieldNm;
                if (i == 2) return this.EL2_FieldNm;
                if (i == 3) return this.EL3_FieldNm;
                if (i == 4) return this.EL4_FieldNm;
                if (i == 5) return this.EL5_FieldNm;
                if (i == 6) return this.EL6_FieldNm;
                if (i == 7) return this.EL7_FieldNm;
                if (i == 8) return this.EL8_FieldNm;
                if (i == 9) return this.EL9_FieldNm;
                if (i == 10) return this.EL10_FieldNm;
                if (i == 11) return this.EL11_FieldNm;
                if (i == 12) return this.EL12_FieldNm;
                else return "[none]";    // false; // "sdfg";
            }
            set
            {
                if (i == 1) this.EL1_FieldNm = value;
                if (i == 2) this.EL2_FieldNm = value;
                if (i == 3) this.EL3_FieldNm = value;
                if (i == 4) this.EL4_FieldNm = value;
                if (i == 5) this.EL5_FieldNm = value;
                if (i == 6) this.EL6_FieldNm = value;
                if (i == 7) this.EL7_FieldNm = value;
                if (i == 8) this.EL8_FieldNm = value;
                if (i == 9) this.EL9_FieldNm = value;
                if (i == 10) this.EL10_FieldNm = value;
                if (i == 11) this.EL11_FieldNm = value;
                if (i == 12) this.EL12_FieldNm = value;
                //else ;
            }
        }


    }
}