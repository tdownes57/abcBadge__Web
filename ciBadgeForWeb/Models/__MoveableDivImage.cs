using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Text.JSON;  // Added 3/20/2020 thomas downes
using Newtonsoft.Json;   // Added 3/20/2020 thomas downes
using ciBadgeElements;  // Added 3/20/2020 thomas downes  

namespace ciBadgeForWeb.JSON
{
    //
    //  Example of JSON for moveable divs/Divs:  
    //
    //  {"Element4_top":"352px","Element4_left":"532px","Element3_top":"352px","Element3_left":"314px","Element6_top":"351px","Element6_left":"91px","Element5_top":"496px","Element5_left":"87px","Element2_top":"499px","Element2_left":"313px","Element1_top":"499px","Element1_left":"535px","Element9_top":"400px","Element9_left":"88px","Element8_top":"448px","Element8_left":"87px","Element10_top":"403px","Element10_left":"314px","Element11_top":"451px","Element11_left":"314px","Element12_top":"404px","Element12_left":"533px","Element7_top":"454px","Element7_left":"535px"}
    //
    public class MoveableDivImage
    {
        //
        // Here below are the Div/Divs Element coordinates.  
        //
        public string Element1_Left { get; set; }
        public string Element2_Left { get; set; }
        public string Element3_Left { get; set; }
        public string Element4_Left { get; set; }
        public string Element5_Left { get; set; }
        public string Element6_Left { get; set; }
        public string Element7_Left { get; set; }
        public string Element8_Left { get; set; }
        public string Element9_Left { get; set; }
        public string Element10_Left { get; set; }
        public string Element11_Left { get; set; }
        public string Element12_Left { get; set; }

        public string Element1_Top { get; set; }
        public string Element2_Top { get; set; }
        public string Element3_Top { get; set; }
        public string Element4_Top { get; set; }
        public string Element5_Top { get; set; }
        public string Element6_Top { get; set; }
        public string Element7_Top { get; set; }
        public string Element8_Top { get; set; }
        public string Element9_Top { get; set; }
        public string Element10_Top { get; set; }
        public string Element11_Top { get; set; }
        public string Element12_Top { get; set; }

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

            this.Element1_Left = (mod_arrayElements[1].LeftEdge_Pixels.ToString() + "px");
            this.Element2_Left = (mod_arrayElements[2].LeftEdge_Pixels.ToString() + "px");
            this.Element3_Left = (mod_arrayElements[3].LeftEdge_Pixels.ToString() + "px");
            this.Element4_Left = (mod_arrayElements[4].LeftEdge_Pixels.ToString() + "px");
            this.Element5_Left = (mod_arrayElements[5].LeftEdge_Pixels.ToString() + "px");
            this.Element6_Left = (mod_arrayElements[6].LeftEdge_Pixels.ToString() + "px");
            this.Element7_Left = (mod_arrayElements[7].LeftEdge_Pixels.ToString() + "px");
            this.Element8_Left = (mod_arrayElements[8].LeftEdge_Pixels.ToString() + "px");
            this.Element9_Left = (mod_arrayElements[9].LeftEdge_Pixels.ToString() + "px");
            this.Element10_Left = (mod_arrayElements[10].LeftEdge_Pixels.ToString() + "px");
            this.Element11_Left = (mod_arrayElements[11].LeftEdge_Pixels.ToString() + "px");
            this.Element12_Left = (mod_arrayElements[12].LeftEdge_Pixels.ToString() + "px");

            this.Element1_Top = (mod_arrayElements[1].TopEdge_Pixels.ToString() + "px");
            this.Element2_Top = (mod_arrayElements[2].TopEdge_Pixels.ToString() + "px");
            this.Element3_Top = (mod_arrayElements[3].TopEdge_Pixels.ToString() + "px");
            this.Element4_Top = (mod_arrayElements[4].TopEdge_Pixels.ToString() + "px");
            this.Element5_Top = (mod_arrayElements[5].TopEdge_Pixels.ToString() + "px");
            this.Element6_Top = (mod_arrayElements[6].TopEdge_Pixels.ToString() + "px");
            this.Element7_Top = (mod_arrayElements[7].TopEdge_Pixels.ToString() + "px");
            this.Element8_Top = (mod_arrayElements[8].TopEdge_Pixels.ToString() + "px");
            this.Element9_Top = (mod_arrayElements[9].TopEdge_Pixels.ToString() + "px");
            this.Element10_Top = (mod_arrayElements[10].TopEdge_Pixels.ToString() + "px");
            this.Element11_Top = (mod_arrayElements[11].TopEdge_Pixels.ToString() + "px");
            this.Element12_Top = (mod_arrayElements[12].TopEdge_Pixels.ToString() + "px");

        }

        public void RefreshProperties(MoveableDivImage par_moveable)
        {
            //
            // Added 3/20/2020 thomas downes  
            //
            this.Element1_Left = (par_moveable.Element1_Left);
            this.Element2_Left = (par_moveable.Element2_Left);
            this.Element3_Left = (par_moveable.Element3_Left);
            this.Element4_Left = (par_moveable.Element4_Left);
            this.Element5_Left = (par_moveable.Element5_Left);
            this.Element6_Left = (par_moveable.Element6_Left);
            this.Element7_Left = (par_moveable.Element7_Left);
            this.Element8_Left = (par_moveable.Element8_Left);
            this.Element9_Left = (par_moveable.Element9_Left);
            this.Element10_Left = (par_moveable.Element10_Left);
            this.Element11_Left = (par_moveable.Element11_Left);
            this.Element12_Left = (par_moveable.Element12_Left);

            this.Element1_Top = (par_moveable.Element1_Top);
            this.Element2_Top = (par_moveable.Element2_Top);
            this.Element3_Top = (par_moveable.Element3_Top);
            this.Element4_Top = (par_moveable.Element4_Top);
            this.Element5_Top = (par_moveable.Element5_Top);
            this.Element6_Top = (par_moveable.Element6_Top);
            this.Element7_Top = (par_moveable.Element7_Top);
            this.Element8_Top = (par_moveable.Element8_Top);
            this.Element9_Top = (par_moveable.Element9_Top);
            this.Element10_Top = (par_moveable.Element10_Top);
            this.Element11_Top = (par_moveable.Element11_Top);
            this.Element12_Top = (par_moveable.Element12_Top);

            mod_arrayElements[1].LeftEdge_Pixels = int.Parse(this.Element1_Left.Replace("px", "")); 
            mod_arrayElements[2].LeftEdge_Pixels = int.Parse(this.Element2_Left.Replace("px", ""));
            mod_arrayElements[3].LeftEdge_Pixels = int.Parse(this.Element3_Left.Replace("px", ""));
            mod_arrayElements[4].LeftEdge_Pixels = int.Parse(this.Element4_Left.Replace("px", ""));
            mod_arrayElements[5].LeftEdge_Pixels = int.Parse(this.Element5_Left.Replace("px", ""));
            mod_arrayElements[6].LeftEdge_Pixels = int.Parse(this.Element6_Left.Replace("px", ""));
            mod_arrayElements[7].LeftEdge_Pixels = int.Parse(this.Element7_Left.Replace("px", ""));
            mod_arrayElements[8].LeftEdge_Pixels = int.Parse(this.Element8_Left.Replace("px", ""));
            mod_arrayElements[9].LeftEdge_Pixels = int.Parse(this.Element9_Left.Replace("px", ""));
            mod_arrayElements[10].LeftEdge_Pixels = int.Parse(this.Element10_Left.Replace("px", ""));
            mod_arrayElements[11].LeftEdge_Pixels = int.Parse(this.Element11_Left.Replace("px", ""));
            mod_arrayElements[12].LeftEdge_Pixels = int.Parse(this.Element12_Left.Replace("px", ""));

            mod_arrayElements[1].TopEdge_Pixels = int.Parse(this.Element1_Top.Replace("px", ""));
            mod_arrayElements[2].TopEdge_Pixels = int.Parse(this.Element2_Top.Replace("px", ""));
            mod_arrayElements[3].TopEdge_Pixels = int.Parse(this.Element3_Top.Replace("px", ""));
            mod_arrayElements[4].TopEdge_Pixels = int.Parse(this.Element4_Top.Replace("px", ""));
            mod_arrayElements[5].TopEdge_Pixels = int.Parse(this.Element5_Top.Replace("px", ""));
            mod_arrayElements[6].TopEdge_Pixels = int.Parse(this.Element6_Top.Replace("px", ""));
            mod_arrayElements[7].TopEdge_Pixels = int.Parse(this.Element7_Top.Replace("px", ""));
            mod_arrayElements[8].TopEdge_Pixels = int.Parse(this.Element8_Top.Replace("px", ""));
            mod_arrayElements[9].TopEdge_Pixels = int.Parse(this.Element9_Top.Replace("px", ""));
            mod_arrayElements[10].TopEdge_Pixels = int.Parse(this.Element10_Top.Replace("px", ""));
            mod_arrayElements[11].TopEdge_Pixels = int.Parse(this.Element11_Top.Replace("px", ""));
            mod_arrayElements[12].TopEdge_Pixels = int.Parse(this.Element12_Top.Replace("px", ""));

        }

    }
}