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
    }
}