using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciBadgeForWeb.Models
{
    public class Moveable_Width
    {
        //
        //  Due to the CSS Style vs. non-CSS sizing, the latter of which applies
        //   below, we use integers as our primitive type.   
        //
        //        <div ....><img .... width="200" > </img> </div>
        //
        //  or more completely, 
        // 
        //        <div id = "EL5" class="mydiv_class" style="position: absolute; top: 250px; left: 100px; ">
        //            <img id="EL5_im" src="@Url.Content("~/Images/blue_star5.jpg")" width="200" height="35" />
        //        </div>
        //
        //   ---4/3/2020 thomas downes   
        //

        public int EL1_Width { get; set; }
        public int EL2_Width { get; set; }
        public int EL3_Width { get; set; }
        public int EL4_Width { get; set; }
        public int EL5_Width { get; set; }
        public int EL6_Width { get; set; }
        public int EL7_Width { get; set; }
        public int EL8_Width { get; set; }
        public int EL9_Width { get; set; }
        public int EL10_Width { get; set; }
        public int EL11_Width { get; set; }
        public int EL12_Width { get; set; }

        public int this[int i]
        {
            get
            {
                if (i == 1) return this.EL1_Width;
                if (i == 2) return this.EL2_Width;
                if (i == 3) return this.EL3_Width;
                if (i == 4) return this.EL4_Width;
                if (i == 5) return this.EL5_Width;
                if (i == 6) return this.EL6_Width;
                if (i == 7) return this.EL7_Width;
                if (i == 8) return this.EL8_Width;
                if (i == 9) return this.EL9_Width;
                if (i == 10) return this.EL10_Width;
                if (i == 11) return this.EL11_Width;
                if (i == 12) return this.EL12_Width;
                else return 19571;  // "sdfg";
            }
            set
            {
                if (i == 1) this.EL1_Width = value;
                if (i == 2) this.EL2_Width = value;
                if (i == 3) this.EL3_Width = value;
                if (i == 4) this.EL4_Width = value;
                if (i == 5) this.EL5_Width = value;
                if (i == 6) this.EL6_Width = value;
                if (i == 7) this.EL7_Width = value;
                if (i == 8) this.EL8_Width = value;
                if (i == 9) this.EL9_Width = value;
                if (i == 10) this.EL10_Width = value;
                if (i == 11) this.EL11_Width = value;
                if (i == 12) this.EL12_Width = value;
                //else ;
            }
        }

    }
}