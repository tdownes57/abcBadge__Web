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
    }
}