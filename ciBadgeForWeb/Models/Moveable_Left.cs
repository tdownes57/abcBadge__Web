using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciBadgeForWeb.Models
{
    public class Moveable_Left
    {
        //
        //  Due to the CSS Style vs. non-CSS sizing, the latter of which applies
        //   below, we use integers as our primitive type.   
        //
        //        <div ... style=".... left: 100px, ..." > </div>
        //
        //  or more completely, 
        // 
        //        <div id = "EL5" class="mydiv_class" style="position: absolute; top: 250px; left: 100px; ">
        //            <img id="EL5_im" src="@Url.Content("~/Images/blue_star5.jpg")" width="200" height="35" />
        //        </div>
        //
        //   ---4/3/2020 thomas downes   
        //
        public string EL1_Left { get; set; }   //E.g. "200px"
        public string EL2_Left { get; set; }  //E.g. "200px"
        public string EL3_Left { get; set; }  //E.g. "200px"
        public string EL4_Left { get; set; }  //E.g. "200px"
        public string EL5_Left { get; set; }  //E.g. "200px"
        public string EL6_Left { get; set; }  //E.g. "200px"
        public string EL7_Left { get; set; }  //E.g. "200px"
        public string EL8_Left { get; set; }  //E.g. "200px"
        public string EL9_Left { get; set; }  //E.g. "200px"
        public string EL10_Left { get; set; }  //E.g. "200px"
        public string EL11_Left { get; set; }  //E.g. "200px"
        public string EL12_Left { get; set; }  //E.g. "200px"
    }
}