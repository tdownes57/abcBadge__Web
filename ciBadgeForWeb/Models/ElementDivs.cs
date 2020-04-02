using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ciBadgeElements; // Added 4/2/2020 thomas downes 
using System.Drawing; 

namespace ciBadgeForWeb.Models
{
    //
    // Added 4/2/2020 thomas downes 
    //
    public class ElementDivs
    {
        //
        // Added 4/2/2020 thomas downes 
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

        public ElementDivs(ClassElementsCache_Deprecated par_cache)
        {
            //
            // Added 4/2/2020 thomas downes 
            //
            foreach (ClassElementField each_element in par_cache.ListOfElementFields)
            {
                if (each_element.IsDisplayedOnBadge_Visibly())
                {
                    //
                    //Get the coordinates. 
                    //
                    Rectangle each_rectangle = new Rectangle( each_element.LeftEdge_Pixels,
                        each_element.TopEdge_Pixels,
                        each_element.Width_Pixels, 
                        each_element.Height_Pixels);

                }
            }
        }





    }
}