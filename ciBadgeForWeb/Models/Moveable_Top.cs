using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;  //Added 4/24/2020 thomas downes

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

        //There is a gap between the 12(+1 for 0th) Standard fields being
        //  possibly displayed, and the five customizable fields.)
        public string EL15_Top { get; set; }
        public string EL16_Top { get; set; }
        public string EL17_Top { get; set; }
        public string EL18_Top { get; set; }
        public string EL19_Top { get; set; }


        public string this[int i]
        {
            get
            {
                //Added 4/17/2020 td
                //-----if (i == 0) return "We are not using index 0.";
                if (i == 0) throw new ArgumentException("We are not using index 0.");

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

                //There is a gap between the 12(+1 for 0th) Standard fields
                //   being possibly displayed, and the five customizable fields.)
                if (i == 15) return this.EL15_Top;
                if (i == 16) return this.EL16_Top;
                if (i == 17) return this.EL17_Top;
                if (i == 18) return this.EL18_Top;
                if (i == 19) return this.EL19_Top;

                else return "sdfg";
            }
            set
            {
                //Added 4/17/2020 td
                //---if (i == 0) return "We are not using index 0.";

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

                //There is a gap between the 12(+1 for 0th) Standard fields
                //  being possibly displayed, and the five customizable fields.)
                if (i == 15) this.EL15_Top = value;
                if (i == 16) this.EL16_Top = value;
                if (i == 17) this.EL17_Top = value;
                if (i == 18) this.EL18_Top = value;
                if (i == 19) this.EL19_Top = value;

                //else ;

            }
        }

        public void RefreshMe_MinusOffsets(Moveable_Top par_oMoveTop, Point par_offset)
        {
            //
            //Added 4/24/2020 thomas downes 
            //
            this.EL1_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL1_Top) - par_offset.Y);
            this.EL2_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL2_Top) - par_offset.Y);
            this.EL3_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL3_Top) - par_offset.Y);
            this.EL4_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL4_Top) - par_offset.Y);
            this.EL5_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL5_Top) - par_offset.Y);
            this.EL6_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL6_Top) - par_offset.Y);
            this.EL7_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL7_Top) - par_offset.Y);
            this.EL8_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL8_Top) - par_offset.Y);
            this.EL9_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL9_Top) - par_offset.Y);

            this.EL10_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL10_Top) - par_offset.Y);
            this.EL11_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL11_Top) - par_offset.Y);
            this.EL12_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL12_Top) - par_offset.Y);

            //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields.)
            this.EL15_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL15_Top) - par_offset.Y);
            this.EL16_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL16_Top) - par_offset.Y);
            this.EL17_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL17_Top) - par_offset.Y);
            this.EL18_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL18_Top) - par_offset.Y);
            this.EL19_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL19_Top) - par_offset.Y);

        }

        public void RefreshMe_AddOffsets(Moveable_Top par_oMoveTop, Point par_offset)
        {
            //
            //Added 4/24/2020 thomas downes 
            //
            this.EL1_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL1_Top) + par_offset.Y);
            this.EL2_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL2_Top) + par_offset.Y);
            this.EL3_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL3_Top) + par_offset.Y);
            this.EL4_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL4_Top) + par_offset.Y);
            this.EL5_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL5_Top) + par_offset.Y);
            this.EL6_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL6_Top) + par_offset.Y);
            this.EL7_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL7_Top) + par_offset.Y);
            this.EL8_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL8_Top) + par_offset.Y);
            this.EL9_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL9_Top) + par_offset.Y);

            this.EL10_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL10_Top) + par_offset.Y);
            this.EL11_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL11_Top) + par_offset.Y);
            this.EL12_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL12_Top) + par_offset.Y);

            //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields.)
            this.EL15_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL15_Top) + par_offset.Y);
            this.EL16_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL16_Top) + par_offset.Y);
            this.EL17_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL17_Top) + par_offset.Y);
            this.EL18_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL18_Top) + par_offset.Y);
            this.EL19_Top = AddPixelSuffix(GetNumber(par_oMoveTop.EL19_Top) + par_offset.Y);


        }
        private string AddPixelSuffix(int par_input)
        {
            // Added 4/24/2020 thomas downes
            return (par_input.ToString() + "px");

        }


        private int GetNumber(string par_num)
        {
            //Added 4/24/2020 thomas downes
            return int.Parse(par_num.Replace("px", ""));
        }


    }
}