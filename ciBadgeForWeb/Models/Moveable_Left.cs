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

        public string this[int i]
        {
            //
            //  4/3/2020 thomas downes 
            //
            get
            {
                //Added 4/17/2020 td
                //----if (i == 0) return "We are not using index 0.";
                if (i == 0) throw new ArgumentException("We are not using index 0.");

                if (i == 1) return this.EL1_Left;
                if (i == 2) return this.EL2_Left;
                if (i == 3) return this.EL3_Left;
                if (i == 4) return this.EL4_Left;
                if (i == 5) return this.EL5_Left;
                if (i == 6) return this.EL6_Left;
                if (i == 7) return this.EL7_Left;
                if (i == 8) return this.EL8_Left;
                if (i == 9) return this.EL9_Left;
                if (i == 10) return this.EL10_Left;
                if (i == 11) return this.EL11_Left;
                if (i == 12) return this.EL12_Left;
                //----else return "sdfg";
                else throw new ArgumentException("The index exceeds 12, which is our current limit.");
            }
            set
            {
                //-----if (i == 0) return "We are not using index 0.";
                if (i == 1) this.EL1_Left = value;
                if (i == 2) this.EL2_Left = value;
                if (i == 3) this.EL3_Left = value;
                if (i == 4) this.EL4_Left = value;
                if (i == 5) this.EL5_Left = value;
                if (i == 6) this.EL6_Left = value;
                if (i == 7) this.EL7_Left = value;
                if (i == 8) this.EL8_Left = value;
                if (i == 9) this.EL9_Left = value;
                if (i == 10) this.EL10_Left = value;
                if (i == 11) this.EL11_Left = value;
                if (i == 12) this.EL12_Left = value;
                //else ;
            }
        }

    }
}