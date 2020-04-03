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
                if (each_element.IsDisplayedOnBadge_Visibly())
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