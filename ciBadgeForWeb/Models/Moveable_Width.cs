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
    }
}