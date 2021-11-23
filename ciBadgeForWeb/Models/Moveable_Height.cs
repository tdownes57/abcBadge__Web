using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciBadgeForWeb.Models
{
    public class Moveable_Height
    {
        //
        //  Due to the CSS Style vs. non-CSS sizing, the latter of which applies
        //   below, we use integers as our primitive type.   
        //
        //        <div ....><img .... height="35" > </img> </div>
        //
        //  or more completely, 
        // 
        //        <div id = "EL5" class="mydiv_class" style="position: absolute; top: 250px; left: 100px; ">
        //            <img id="EL5_im" src="@Url.Content("~/Images/blue_star5.jpg")" width="200" height="35" />
        //        </div>
        //
        //   ---4/3/2020 thomas downes   
        //

        public int EL1_Height { get; set; }
        public int EL2_Height { get; set; }
        public int EL3_Height { get; set; }
        public int EL4_Height { get; set; }
        public int EL5_Height { get; set; }
        public int EL6_Height { get; set; }
        public int EL7_Height { get; set; }
        public int EL8_Height { get; set; }
        public int EL9_Height { get; set; }
        public int EL10_Height { get; set; }
        public int EL11_Height { get; set; }
        public int EL12_Height { get; set; }

        //There is a gap between the 12(+1 for 0th) Standard fields being
        //   possibly displayed, and the five customizable fields.)
        public int EL15_Height { get; set; }
        public int EL16_Height { get; set; }
        public int EL17_Height { get; set; }
        public int EL18_Height { get; set; }
        public int EL19_Height { get; set; }


        public int this[int i]
        {
            get
            {
                if (i == 1) return this.EL1_Height;
                if (i == 2) return this.EL2_Height;
                if (i == 3) return this.EL3_Height;
                if (i == 4) return this.EL4_Height;
                if (i == 5) return this.EL5_Height;
                if (i == 6) return this.EL6_Height;
                if (i == 7) return this.EL7_Height;
                if (i == 8) return this.EL8_Height;
                if (i == 9) return this.EL9_Height;
                if (i == 10) return this.EL10_Height;
                if (i == 11) return this.EL11_Height;
                if (i == 12) return this.EL12_Height;

                //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields.)
                if (i == 15) return this.EL15_Height;
                if (i == 16) return this.EL16_Height;
                if (i == 17) return this.EL17_Height;
                if (i == 18) return this.EL18_Height;
                if (i == 19) return this.EL19_Height;


                else return 1655; // "sdfg";
            }
            set
            {
                if (i == 1) this.EL1_Height = value;
                if (i == 2) this.EL2_Height = value;
                if (i == 3) this.EL3_Height = value;
                if (i == 4) this.EL4_Height = value;
                if (i == 5) this.EL5_Height = value;
                if (i == 6) this.EL6_Height = value;
                if (i == 7) this.EL7_Height = value;
                if (i == 8) this.EL8_Height = value;
                if (i == 9) this.EL9_Height = value;
                if (i == 10) this.EL10_Height = value;
                if (i == 11) this.EL11_Height = value;
                if (i == 12) this.EL12_Height = value;

                //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields.)
                if (i == 15) this.EL15_Height = value;
                if (i == 16) this.EL16_Height = value;
                if (i == 17) this.EL17_Height = value;
                if (i == 18) this.EL18_Height = value;
                if (i == 19) this.EL19_Height = value;


                //else ;
            }
        }

    }
}