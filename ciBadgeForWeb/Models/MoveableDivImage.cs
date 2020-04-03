using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Text.JSON;  // Added 3/20/2020 thomas downes
using Newtonsoft.Json;   // Added 3/20/2020 thomas downes
using ciBadgeElements;  // Added 3/20/2020 thomas downes  

namespace ciBadgeForWeb.JSON
{
    //    //
    // The class below has been moved to the folder Models. 
    //    //   ---  So, see Models/MoveableElementDivs.cs.  -----4/2/2020 thomas d. 
    //    //   ---  So, see Models/MoveableDivImage.cs.  -----4/2/2020 thomas d. 
    //
    //  Example of JSON for moveable divs/Divs:  
    //
    //  {"EL4_top":"352px","EL4_left":"532px","EL3_top":"352px","EL3_left":"314px","EL6_top":"351px","EL6_left":"91px","EL5_top":"496px","EL5_left":"87px","EL2_top":"499px","EL2_left":"313px","EL1_top":"499px","EL1_left":"535px","EL9_top":"400px","EL9_left":"88px","EL8_top":"448px","EL8_left":"87px","EL10_top":"403px","EL10_left":"314px","EL11_top":"451px","EL11_left":"314px","EL12_top":"404px","EL12_left":"533px","EL7_top":"454px","EL7_left":"535px"}
    //
    public class MoveableDivImage
    {
        //
        // The class below has been moved to the folder Models. 
        //    //   ---  So, see Models/MoveableElementDivs.cs.  -----4/2/2020 thomas d. 
        //    //   ---  So, see Models/MoveableDivImage.cs.  -----4/2/2020 thomas d. 
        //
        // Here below are the Div/Divs Element coordinates.  
        //
        public string EL1_Left { get; set; }
        public string EL2_Left { get; set; }
        public string EL3_Left { get; set; }
        public string EL4_Left { get; set; }
        public string EL5_Left { get; set; }
        public string EL6_Left { get; set; }
        public string EL7_Left { get; set; }
        public string EL8_Left { get; set; }
        public string EL9_Left { get; set; }
        public string EL10_Left { get; set; }
        public string EL11_Left { get; set; }
        public string EL12_Left { get; set; }

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

        //private ClassElementField _Element1 = null;
        //private ClassElementField _Element2 = null;
        //private ClassElementField _Element3 = null;
        //private ClassElementField _Element4 = null;
        //private ClassElementField _Element5 = null;
        //private ClassElementField _Element6 = null;
        //private ClassElementField _Element7 = null;
        //private ClassElementField _Element9 = null;
        //private ClassElementField _Element10 = null;
        //private ClassElementField _Element11 = null;
        //private ClassElementField _Element12 = null;
        //private ClassElementField _Element13 = null;

        // Initializ the array. ---3/20/2020 thomas downes 
        private ClassElementField[] mod_arrayElements = new ClassElementField[12];

        //
        // Initialize. ---3/20/2020 thomas downes 
        //
        public MoveableDivImage(ciBadgeElements.ClassElementsCache_Deprecated par_cache)
        {
            //
            // Added 3/20/2020 thomas downes 
            //
            int indexElement = 0;

            foreach (ClassElementField each_element in par_cache.ListOfElementFields)
            {
                if (each_element.IsDisplayedOnBadge_Visibly())
                {
                    indexElement++;
                    mod_arrayElements[indexElement] = each_element;
                }
            }

            this.EL1_Left = (mod_arrayElements[1].LeftEdge_Pixels.ToString() + "px");
            this.EL2_Left = (mod_arrayElements[2].LeftEdge_Pixels.ToString() + "px");
            this.EL3_Left = (mod_arrayElements[3].LeftEdge_Pixels.ToString() + "px");
            this.EL4_Left = (mod_arrayElements[4].LeftEdge_Pixels.ToString() + "px");
            this.EL5_Left = (mod_arrayElements[5].LeftEdge_Pixels.ToString() + "px");
            this.EL6_Left = (mod_arrayElements[6].LeftEdge_Pixels.ToString() + "px");
            this.EL7_Left = (mod_arrayElements[7].LeftEdge_Pixels.ToString() + "px");
            this.EL8_Left = (mod_arrayElements[8].LeftEdge_Pixels.ToString() + "px");
            this.EL9_Left = (mod_arrayElements[9].LeftEdge_Pixels.ToString() + "px");
            this.EL10_Left = (mod_arrayElements[10].LeftEdge_Pixels.ToString() + "px");
            this.EL11_Left = (mod_arrayElements[11].LeftEdge_Pixels.ToString() + "px");
            this.EL12_Left = (mod_arrayElements[12].LeftEdge_Pixels.ToString() + "px");

            this.EL1_Top = (mod_arrayElements[1].TopEdge_Pixels.ToString() + "px");
            this.EL2_Top = (mod_arrayElements[2].TopEdge_Pixels.ToString() + "px");
            this.EL3_Top = (mod_arrayElements[3].TopEdge_Pixels.ToString() + "px");
            this.EL4_Top = (mod_arrayElements[4].TopEdge_Pixels.ToString() + "px");
            this.EL5_Top = (mod_arrayElements[5].TopEdge_Pixels.ToString() + "px");
            this.EL6_Top = (mod_arrayElements[6].TopEdge_Pixels.ToString() + "px");
            this.EL7_Top = (mod_arrayElements[7].TopEdge_Pixels.ToString() + "px");
            this.EL8_Top = (mod_arrayElements[8].TopEdge_Pixels.ToString() + "px");
            this.EL9_Top = (mod_arrayElements[9].TopEdge_Pixels.ToString() + "px");
            this.EL10_Top = (mod_arrayElements[10].TopEdge_Pixels.ToString() + "px");
            this.EL11_Top = (mod_arrayElements[11].TopEdge_Pixels.ToString() + "px");
            this.EL12_Top = (mod_arrayElements[12].TopEdge_Pixels.ToString() + "px");

        }

        public void RefreshProperties(MoveableDivImage par_moveable)
        {
            //
            // Added 3/20/2020 thomas downes  
            //
            this.EL1_Left = (par_moveable.EL1_Left);
            this.EL2_Left = (par_moveable.EL2_Left);
            this.EL3_Left = (par_moveable.EL3_Left);
            this.EL4_Left = (par_moveable.EL4_Left);
            this.EL5_Left = (par_moveable.EL5_Left);
            this.EL6_Left = (par_moveable.EL6_Left);
            this.EL7_Left = (par_moveable.EL7_Left);
            this.EL8_Left = (par_moveable.EL8_Left);
            this.EL9_Left = (par_moveable.EL9_Left);
            this.EL10_Left = (par_moveable.EL10_Left);
            this.EL11_Left = (par_moveable.EL11_Left);
            this.EL12_Left = (par_moveable.EL12_Left);

            this.EL1_Top = (par_moveable.EL1_Top);
            this.EL2_Top = (par_moveable.EL2_Top);
            this.EL3_Top = (par_moveable.EL3_Top);
            this.EL4_Top = (par_moveable.EL4_Top);
            this.EL5_Top = (par_moveable.EL5_Top);
            this.EL6_Top = (par_moveable.EL6_Top);
            this.EL7_Top = (par_moveable.EL7_Top);
            this.EL8_Top = (par_moveable.EL8_Top);
            this.EL9_Top = (par_moveable.EL9_Top);
            this.EL10_Top = (par_moveable.EL10_Top);
            this.EL11_Top = (par_moveable.EL11_Top);
            this.EL12_Top = (par_moveable.EL12_Top);

            mod_arrayElements[1].LeftEdge_Pixels = int.Parse(this.EL1_Left.Replace("px", "")); 
            mod_arrayElements[2].LeftEdge_Pixels = int.Parse(this.EL2_Left.Replace("px", ""));
            mod_arrayElements[3].LeftEdge_Pixels = int.Parse(this.EL3_Left.Replace("px", ""));
            mod_arrayElements[4].LeftEdge_Pixels = int.Parse(this.EL4_Left.Replace("px", ""));
            mod_arrayElements[5].LeftEdge_Pixels = int.Parse(this.EL5_Left.Replace("px", ""));
            mod_arrayElements[6].LeftEdge_Pixels = int.Parse(this.EL6_Left.Replace("px", ""));
            mod_arrayElements[7].LeftEdge_Pixels = int.Parse(this.EL7_Left.Replace("px", ""));
            mod_arrayElements[8].LeftEdge_Pixels = int.Parse(this.EL8_Left.Replace("px", ""));
            mod_arrayElements[9].LeftEdge_Pixels = int.Parse(this.EL9_Left.Replace("px", ""));
            mod_arrayElements[10].LeftEdge_Pixels = int.Parse(this.EL10_Left.Replace("px", ""));
            mod_arrayElements[11].LeftEdge_Pixels = int.Parse(this.EL11_Left.Replace("px", ""));
            mod_arrayElements[12].LeftEdge_Pixels = int.Parse(this.EL12_Left.Replace("px", ""));

            mod_arrayElements[1].TopEdge_Pixels = int.Parse(this.EL1_Top.Replace("px", ""));
            mod_arrayElements[2].TopEdge_Pixels = int.Parse(this.EL2_Top.Replace("px", ""));
            mod_arrayElements[3].TopEdge_Pixels = int.Parse(this.EL3_Top.Replace("px", ""));
            mod_arrayElements[4].TopEdge_Pixels = int.Parse(this.EL4_Top.Replace("px", ""));
            mod_arrayElements[5].TopEdge_Pixels = int.Parse(this.EL5_Top.Replace("px", ""));
            mod_arrayElements[6].TopEdge_Pixels = int.Parse(this.EL6_Top.Replace("px", ""));
            mod_arrayElements[7].TopEdge_Pixels = int.Parse(this.EL7_Top.Replace("px", ""));
            mod_arrayElements[8].TopEdge_Pixels = int.Parse(this.EL8_Top.Replace("px", ""));
            mod_arrayElements[9].TopEdge_Pixels = int.Parse(this.EL9_Top.Replace("px", ""));
            mod_arrayElements[10].TopEdge_Pixels = int.Parse(this.EL10_Top.Replace("px", ""));
            mod_arrayElements[11].TopEdge_Pixels = int.Parse(this.EL11_Top.Replace("px", ""));
            mod_arrayElements[12].TopEdge_Pixels = int.Parse(this.EL12_Top.Replace("px", ""));

        }

        public string JSON_Left()
        {


        }

        public string JSON_Top()
        {


        }

        public string JSON_Width()
        {


        }

        public string JSON_Height()
        {


        }

    }
}