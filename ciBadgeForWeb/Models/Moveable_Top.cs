using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciBadgeForWeb.Models
{
    public class Moveable_Top
    {
        //
        //  Due to the CSS Style vs. non-CSS sizing, the latter of which applies
        //   below, we use integers as our primitive type.   
        //
        //        <div ... style=".... top: 100px, ..." > </div>
        //
        //  or more completely, 
        // 
        //        <div id = "EL5" class="mydiv_class" style="position: absolute; top: 250px; left: 100px; ">
        //            <img id="EL5_im" src="@Url.Content("~/Images/blue_star5.jpg")" width="200" height="35" />
        //        </div>
        //
        //   ---4/3/2020 thomas downes   
        //

        public string EL1_Top { get; set; }
        public string EL2_Top { get; set; }
        public string EL3_Top { get; set; }
        public string EL4_Top { get; set; }
        public string EL5_Top { get; set; }
        public string EL6_Top { get; set; }
        public string EL7_Top { get; set; }
        public string EL8_Top { get; set; }
        public string EL9_Top { get; set; }
        public string EL10_Top { get; set; }
        public string EL11_Top { get; set; }
        public string EL12_Top { get; set; }


        public string this[int i]
        {
            get
            {
                if (i == 1) return this.EL1_Top;
                if (i == 2) return this.EL2_Top;
                if (i == 3) return this.EL3_Top;
                if (i == 4) return this.EL4_Top;
                if (i == 5) return this.EL5_Top;
                if (i == 6) return this.EL6_Top;
                if (i == 7) return this.EL7_Top;
                if (i == 8) return this.EL8_Top;
                if (i == 9) return this.EL9_Top;
                if (i == 10) return this.EL10_Top;
                if (i == 11) return this.EL11_Top;
                if (i == 12) return this.EL12_Top;
                else return "sdfg";
            }
            set
            {
                if (i == 1) this.EL1_Top = value;
                if (i == 2) this.EL2_Top = value;
                if (i == 3) this.EL3_Top = value;
                if (i == 4) this.EL4_Top = value;
                if (i == 5) this.EL5_Top = value;
                if (i == 6) this.EL6_Top = value;
                if (i == 7) this.EL7_Top = value;
                if (i == 8) this.EL8_Top = value;
                if (i == 9) this.EL9_Top = value;
                if (i == 10) this.EL10_Top = value;
                if (i == 11) this.EL11_Top = value;
                if (i == 12) this.EL12_Top = value;
                //else ;
            }
        }

    }
}