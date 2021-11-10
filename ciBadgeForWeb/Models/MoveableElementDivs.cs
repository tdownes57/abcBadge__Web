using ciBadgeElements; // Added 4/2/2020 thomas downes 
using System.Drawing;

namespace ciBadgeForWeb.Models
{
    //
    // Added 4/2/2020 thomas downes 
    //
    // The class below has been moved to the folder Models. 
    //     //   ---  So, see Models/MoveableElementDivs.cs.  -----4/2/2020 thomas d. 
    //     //   ---  So, see Models/MoveableDivImage.cs.  -----4/2/2020 thomas d. 
    //
    //
    public class MoveableElementDivs
    {
        //
        // Added 4/2/2020 thomas downes 
        //
        // The class below has been moved to the folder Models. 
        //    //   ---  So, see Models/MoveableElementDivs.cs.  -----4/2/2020 thomas d. 
        //    //   ---  So, see Models/MoveableDivImage.cs.  -----4/2/2020 thomas d. 
        //    //
        //     // See also, the CIBadgeElements Project, for JSON- & DIVs- related code. 
        //     //   ---Actually, I wasn't able to find it, so maybe I didn't do it.
        //     //   ---  So, see Models/ElementDivs.cs.  -----4/2/2020 thomas d. 
        //
        //  Example of JSON for moveable divs/Divs:  
        //
        //  Left:
        //      {"EL1_Left":"974px","EL2_Left":"1057px","EL3_Left":"343px","EL4_Left":"133px","EL5_Left":"1079px","EL6_Left":"894px","EL7_Left":"294px","EL8_Left":"396px","EL9_Left":"552px","EL10_Left":"819px","EL11_Left":"435px","EL12_Left":"771px"} 
        //  Top:
        //      {"EL1_Top":"120px","EL2_Top":"225px","EL3_Top":"523px","EL4_Top":"343px","EL5_Top":"392px","EL6_Top":"455px","EL7_Top":"128px","EL8_Top":"425px","EL9_Top":"133px","EL10_Top":"395px","EL11_Top":"299px","EL12_Top":"317px"} 
        //  Width: 
        //      {"EL4_Width":505,"EL3_Width":"150","EL6_Width":"200","EL5_Width":"200","EL2_Width":"150","EL1_Width":"150","EL9_Width":"200","EL8_Width":"200","EL10_Width":"200","EL11_Width":"200","EL12_Width":"200","EL7_Width":"200"}      
        //  Height:  
        //    {"EL4_Height":35,"EL3_Height":"35","EL6_Height":"35","EL5_Height":"35","EL2_Height":"35","EL1_Height":"35","EL9_Height":"35","EL8_Height":"35","EL10_Height":"35","EL11_Height":"35","EL12_Height":"35","EL7_Height":"35"}   
        //
        //
        public Rectangle Div1 { get; set; }
        public Rectangle Div2 { get; set; }
        public Rectangle Div3 { get; set; }
        public Rectangle Div4 { get; set; }
        public Rectangle Div5 { get; set; }
        public Rectangle Div6 { get; set; }
        public Rectangle Div7 { get; set; }
        public Rectangle Div8 { get; set; }
        public Rectangle Div9 { get; set; }
        public Rectangle Div10 { get; set; }
        public Rectangle Div11 { get; set; }
        public Rectangle Div12 { get; set; }

        public ClassElementField Div1_Element { get; set; }
        public ClassElementField Div2_Element { get; set; }
        public ClassElementField Div3_Element { get; set; }
        public ClassElementField Div4_Element { get; set; }
        public ClassElementField Div5_Element { get; set; }
        public ClassElementField Div6_Element { get; set; }
        public ClassElementField Div7_Element { get; set; }
        public ClassElementField Div8_Element { get; set; }
        public ClassElementField Div9_Element { get; set; }
        public ClassElementField Div10_Element { get; set; }
        public ClassElementField Div11_Element { get; set; }
        public ClassElementField Div12_Element { get; set; }

        public MoveableElementDivs(ClassElementsCache_Deprecated par_cache)
        {
            //
            // Added 4/2/2020 thomas downes 
            //
            int intDivIndex = 0;

            foreach (ClassElementField each_element in par_cache.ListOfElementFields)
            {
                WhyOmitted structWhy = new WhyOmitted(); // Added 11/10/2021 td

                //if (each_element.IsDisplayedOnBadge_Visibly())
                if (each_element.IsDisplayedOnBadge_Visibly(ref structWhy))
                {
                    intDivIndex++;

                    //
                    //Get the coordinates. 
                    //
                    Rectangle each_rectangle = new Rectangle(each_element.LeftEdge_Pixels,
                        each_element.TopEdge_Pixels,
                        each_element.Width_Pixels,
                        each_element.Height_Pixels);

                    if (intDivIndex == 1) this.Div1 = each_rectangle;
                    if (intDivIndex == 2) this.Div2 = each_rectangle;
                    if (intDivIndex == 3) this.Div3 = each_rectangle;
                    if (intDivIndex == 4) this.Div4 = each_rectangle;
                    if (intDivIndex == 5) this.Div5 = each_rectangle;
                    if (intDivIndex == 6) this.Div6 = each_rectangle;
                    if (intDivIndex == 7) this.Div7 = each_rectangle;
                    if (intDivIndex == 8) this.Div8 = each_rectangle;
                    if (intDivIndex == 9) this.Div9 = each_rectangle;
                    if (intDivIndex == 10) this.Div10 = each_rectangle;
                    if (intDivIndex == 11) this.Div11 = each_rectangle;
                    if (intDivIndex == 12) this.Div12 = each_rectangle;

                    //
                    //  Let's store a link back to the Element Field, so as to 
                    //    enable storing the layout modifications. 
                    //
                    if (intDivIndex == 1) this.Div1_Element = each_element;
                    if (intDivIndex == 2) this.Div2_Element = each_element;
                    if (intDivIndex == 3) this.Div3_Element = each_element;
                    if (intDivIndex == 4) this.Div4_Element = each_element;
                    if (intDivIndex == 5) this.Div5_Element = each_element;
                    if (intDivIndex == 6) this.Div6_Element = each_element;
                    if (intDivIndex == 7) this.Div7_Element = each_element;
                    if (intDivIndex == 8) this.Div8_Element = each_element;
                    if (intDivIndex == 9) this.Div9_Element = each_element;
                    if (intDivIndex == 10) this.Div10_Element = each_element;
                    if (intDivIndex == 11) this.Div11_Element = each_element;
                    if (intDivIndex == 12) this.Div12_Element = each_element;

                }
            }
        }





    }
}