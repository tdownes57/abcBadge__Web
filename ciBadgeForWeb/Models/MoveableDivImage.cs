using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Text.JSON;  // Added 3/20/2020 thomas downes
using Newtonsoft.Json;   // Added 3/20/2020 thomas downes
using ciBadgeElements;  // Added 3/20/2020 thomas downes  

namespace ciBadgeForWeb.Models
{
    //    
    // The class below has been moved to the folder Models (from the folder JSON). 
    //
    //    ---  So, see Models/MoveableElementDivs.cs.  -----4/2/2020 thomas d. 
    //    ---  So, see Models/MoveableDivImage.cs.  -----4/2/2020 thomas d. 
    //
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
    public class MoveableDivImage
    {
        //
        // The class below has been moved to the folder Models. 
        //    //   ---  So, see Models/MoveableElementDivs.cs.  -----4/2/2020 thomas d. 
        //    //   ---  So, see Models/MoveableDivImage.cs.  -----4/2/2020 thomas d. 
        //
        // Here below are the Div/Divs Element coordinates.  
        //
        //public string EL1_Left { get; set; }
        //public string EL2_Left { get; set; }
        //public string EL3_Left { get; set; }
        //public string EL4_Left { get; set; }
        //public string EL5_Left { get; set; }
        //public string EL6_Left { get; set; }
        //public string EL7_Left { get; set; }
        //public string EL8_Left { get; set; }
        //public string EL9_Left { get; set; }
        //public string EL10_Left { get; set; }
        //public string EL11_Left { get; set; }
        //public string EL12_Left { get; set; }

        //public string EL1_Top { get; set; }
        //public string EL2_Top { get; set; }
        //public string EL3_Top { get; set; }
        //public string EL4_Top { get; set; }
        //public string EL5_Top { get; set; }
        //public string EL6_Top { get; set; }
        //public string EL7_Top { get; set; }
        //public string EL8_Top { get; set; }
        //public string EL9_Top { get; set; }
        //public string EL10_Top { get; set; }
        //public string EL11_Top { get; set; }
        //public string EL12_Top { get; set; }

        //public int EL1_Width { get; set; }
        //public int EL2_Width { get; set; }
        //public int EL3_Width { get; set; }
        //public int EL4_Width { get; set; }
        //public int EL5_Width { get; set; }
        //public int EL6_Width { get; set; }
        //public int EL7_Width { get; set; }
        //public int EL8_Width { get; set; }
        //public int EL9_Width { get; set; }
        //public int EL10_Width { get; set; }
        //public int EL11_Width { get; set; }
        //public int EL12_Width { get; set; }

        
        //public int EL1_Height { get; set; }
        //public int EL2_Height { get; set; }
        //public int EL3_Height { get; set; }
        //public int EL4_Height { get; set; }
        //public int EL5_Height { get; set; }
        //public int EL6_Height { get; set; }
        //public int EL7_Height { get; set; }
        //public int EL8_Height { get; set; }
        //public int EL9_Height { get; set; }
        //public int EL10_Height { get; set; }
        //public int EL11_Height { get; set; }
        //public int EL12_Height { get; set; }


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
        //----4/3/2020 td---
        private ClassElementField[] mod_arrayElements = new ClassElementField[12];

        private Newtonsoft.Json.JsonConverter mod_converter_Left;
        private Newtonsoft.Json.JsonConverter mod_converter_Top;
        private Newtonsoft.Json.JsonConverter mod_converter_Width;
        private Newtonsoft.Json.JsonConverter mod_converter_Height;

        public Moveable_Left MoveLeft;
        public Moveable_Top MoveTop;
        public Moveable_Width MoveWidth;
        public Moveable_Height MoveHeight;

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

            //this.EL1_Left = (mod_arrayElements[1].LeftEdge_Pixels.ToString() + "px");
            //this.EL2_Left = (mod_arrayElements[2].LeftEdge_Pixels.ToString() + "px");
            //this.EL3_Left = (mod_arrayElements[3].LeftEdge_Pixels.ToString() + "px");
            //this.EL4_Left = (mod_arrayElements[4].LeftEdge_Pixels.ToString() + "px");
            //this.EL5_Left = (mod_arrayElements[5].LeftEdge_Pixels.ToString() + "px");
            //this.EL6_Left = (mod_arrayElements[6].LeftEdge_Pixels.ToString() + "px");
            //this.EL7_Left = (mod_arrayElements[7].LeftEdge_Pixels.ToString() + "px");
            //this.EL8_Left = (mod_arrayElements[8].LeftEdge_Pixels.ToString() + "px");
            //this.EL9_Left = (mod_arrayElements[9].LeftEdge_Pixels.ToString() + "px");
            //this.EL10_Left = (mod_arrayElements[10].LeftEdge_Pixels.ToString() + "px");
            //this.EL11_Left = (mod_arrayElements[11].LeftEdge_Pixels.ToString() + "px");
            //this.EL12_Left = (mod_arrayElements[12].LeftEdge_Pixels.ToString() + "px");

            //this.EL1_Top = (mod_arrayElements[1].TopEdge_Pixels.ToString() + "px");
            //this.EL2_Top = (mod_arrayElements[2].TopEdge_Pixels.ToString() + "px");
            //this.EL3_Top = (mod_arrayElements[3].TopEdge_Pixels.ToString() + "px");
            //this.EL4_Top = (mod_arrayElements[4].TopEdge_Pixels.ToString() + "px");
            //this.EL5_Top = (mod_arrayElements[5].TopEdge_Pixels.ToString() + "px");
            //this.EL6_Top = (mod_arrayElements[6].TopEdge_Pixels.ToString() + "px");
            //this.EL7_Top = (mod_arrayElements[7].TopEdge_Pixels.ToString() + "px");
            //this.EL8_Top = (mod_arrayElements[8].TopEdge_Pixels.ToString() + "px");
            //this.EL9_Top = (mod_arrayElements[9].TopEdge_Pixels.ToString() + "px");
            //this.EL10_Top = (mod_arrayElements[10].TopEdge_Pixels.ToString() + "px");
            //this.EL11_Top = (mod_arrayElements[11].TopEdge_Pixels.ToString() + "px");
            //this.EL12_Top = (mod_arrayElements[12].TopEdge_Pixels.ToString() + "px");

        }

        public void RefreshProperties(MoveableDivImage par_moveable)
        {
            //
            // Added 3/20/2020 thomas downes  
            //
            //---this.EL1_Left = (par_moveable.EL1_Left);
            //---this.EL2_Left = (par_moveable.EL2_Left);
            //---this.EL3_Left = (par_moveable.EL3_Left);
            //---this.EL4_Left = (par_moveable.EL4_Left);
            //---this.EL5_Left = (par_moveable.EL5_Left);
            //---this.EL6_Left = (par_moveable.EL6_Left);
            //---this.EL7_Left = (par_moveable.EL7_Left);
            //---this.EL8_Left = (par_moveable.EL8_Left);
            //---this.EL9_Left = (par_moveable.EL9_Left);
            //---this.EL10_Left = (par_moveable.EL10_Left);
            //---this.EL11_Left = (par_moveable.EL11_Left);
            //---this.EL12_Left = (par_moveable.EL12_Left);

            this.MoveLeft.EL1_Left = (par_moveable.MoveLeft.EL1_Left);
            this.MoveLeft.EL2_Left = (par_moveable.MoveLeft.EL2_Left);
            this.MoveLeft.EL3_Left = (par_moveable.MoveLeft.EL3_Left);
            this.MoveLeft.EL4_Left = (par_moveable.MoveLeft.EL4_Left);
            this.MoveLeft.EL5_Left = (par_moveable.MoveLeft.EL5_Left);
            this.MoveLeft.EL6_Left = (par_moveable.MoveLeft.EL6_Left);
            this.MoveLeft.EL7_Left = (par_moveable.MoveLeft.EL7_Left);
            this.MoveLeft.EL8_Left = (par_moveable.MoveLeft.EL8_Left);
            this.MoveLeft.EL9_Left = (par_moveable.MoveLeft.EL9_Left);
            this.MoveLeft.EL10_Left = (par_moveable.MoveLeft.EL10_Left);
            this.MoveLeft.EL11_Left = (par_moveable.MoveLeft.EL11_Left);
            this.MoveLeft.EL12_Left = (par_moveable.MoveLeft.EL12_Left);

            this.MoveTop.EL1_Top = (par_moveable.MoveTop.EL1_Top);
            this.MoveTop.EL2_Top = (par_moveable.MoveTop.EL2_Top);
            this.MoveTop.EL3_Top = (par_moveable.MoveTop.EL3_Top);
            this.MoveTop.EL4_Top = (par_moveable.MoveTop.EL4_Top);
            this.MoveTop.EL5_Top = (par_moveable.MoveTop.EL5_Top);
            this.MoveTop.EL6_Top = (par_moveable.MoveTop.EL6_Top);
            this.MoveTop.EL7_Top = (par_moveable.MoveTop.EL7_Top);
            this.MoveTop.EL8_Top = (par_moveable.MoveTop.EL8_Top);
            this.MoveTop.EL9_Top = (par_moveable.MoveTop.EL9_Top);
            this.MoveTop.EL10_Top = (par_moveable.MoveTop.EL10_Top);
            this.MoveTop.EL11_Top = (par_moveable.MoveTop.EL11_Top);
            this.MoveTop.EL12_Top = (par_moveable.MoveTop.EL12_Top);

            //---mod_arrayElements[1].LeftEdge_Pixels = int.Parse(this.EL1_Left.Replace("px", "")); 
            //---mod_arrayElements[2].LeftEdge_Pixels = int.Parse(this.EL2_Left.Replace("px", ""));
            //---mod_arrayElements[3].LeftEdge_Pixels = int.Parse(this.EL3_Left.Replace("px", ""));
            //---mod_arrayElements[4].LeftEdge_Pixels = int.Parse(this.EL4_Left.Replace("px", ""));
            //---mod_arrayElements[5].LeftEdge_Pixels = int.Parse(this.EL5_Left.Replace("px", ""));
            //---mod_arrayElements[6].LeftEdge_Pixels = int.Parse(this.EL6_Left.Replace("px", ""));
            //---mod_arrayElements[7].LeftEdge_Pixels = int.Parse(this.EL7_Left.Replace("px", ""));
            //---mod_arrayElements[8].LeftEdge_Pixels = int.Parse(this.EL8_Left.Replace("px", ""));
            //---mod_arrayElements[9].LeftEdge_Pixels = int.Parse(this.EL9_Left.Replace("px", ""));
            //---mod_arrayElements[10].LeftEdge_Pixels = int.Parse(this.EL10_Left.Replace("px", ""));
            //---mod_arrayElements[11].LeftEdge_Pixels = int.Parse(this.EL11_Left.Replace("px", ""));
            //---mod_arrayElements[12].LeftEdge_Pixels = int.Parse(this.EL12_Left.Replace("px", ""));

            //---mod_arrayElements[1].TopEdge_Pixels = int.Parse(this.EL1_Top.Replace("px", ""));
            //---mod_arrayElements[2].TopEdge_Pixels = int.Parse(this.EL2_Top.Replace("px", ""));
            //---mod_arrayElements[3].TopEdge_Pixels = int.Parse(this.EL3_Top.Replace("px", ""));
            //---mod_arrayElements[4].TopEdge_Pixels = int.Parse(this.EL4_Top.Replace("px", ""));
            //---mod_arrayElements[5].TopEdge_Pixels = int.Parse(this.EL5_Top.Replace("px", ""));
            //---mod_arrayElements[6].TopEdge_Pixels = int.Parse(this.EL6_Top.Replace("px", ""));
            //---mod_arrayElements[7].TopEdge_Pixels = int.Parse(this.EL7_Top.Replace("px", ""));
            //---mod_arrayElements[8].TopEdge_Pixels = int.Parse(this.EL8_Top.Replace("px", ""));
            //---mod_arrayElements[9].TopEdge_Pixels = int.Parse(this.EL9_Top.Replace("px", ""));
            //---mod_arrayElements[10].TopEdge_Pixels = int.Parse(this.EL10_Top.Replace("px", ""));
            //---mod_arrayElements[11].TopEdge_Pixels = int.Parse(this.EL11_Top.Replace("px", ""));
            //---mod_arrayElements[12].TopEdge_Pixels = int.Parse(this.EL12_Top.Replace("px", ""));

        }

        public string GetJSON_Left()
        {
            //
            // Added 4/3/2020 thomas downes
            //
            //Newtonsoft.Json.JsonConverter new_converter; 

            //mod_converter_Left = JsonConvert.SerializeObject();

            JsonSerializerSettings json_options = new JsonSerializerSettings();

            json_options.Formatting = Formatting.Indented;

            // 4-5-2020 TD//mod_converter_Left = JsonConvert.SerializeObject(this.MoveLeft, this.MoveLeft.GetType(), json_options );
            // 4-5-2020 TD//mod_converter_Left = new JsonConverter<Moveable_Left>()
            // 4-5-2020 TD//string strOutput = JsonConvert.SerializeObject(this.MoveLeft, this.MoveLeft.GetType(), json_options);

            string strOutput = JsonConvert.SerializeObject(this.MoveLeft);

            return strOutput; 

        }

        public string GetJSON_Top()
        {
            //
            // Added 4/3/2020 thomas downes
            //
            JsonSerializerSettings json_options = new JsonSerializerSettings();
            json_options.Formatting = Formatting.Indented;

            string strOutput = JsonConvert.SerializeObject(this.MoveTop, this.MoveTop.GetType(), json_options);

            return strOutput;

        }

        public string GetJSON_Width()
        {
            //
            // Added 4/3/2020 thomas downes
            //
            JsonSerializerSettings json_options = new JsonSerializerSettings();
            json_options.Formatting = Formatting.Indented;
            string strOutput = JsonConvert.SerializeObject(this.MoveWidth, this.MoveWidth.GetType(), json_options);
            return strOutput;

        }

        public string GetJSON_Height()
        {
            //
            // Added 4/3/2020 thomas downes
            //
            JsonSerializerSettings json_options = new JsonSerializerSettings();
            json_options.Formatting = Formatting.Indented;
            string strOutput = JsonConvert.SerializeObject(this.MoveHeight, this.MoveHeight.GetType(), json_options);
            return strOutput;

        }

        public void SavePositions_Left(string par_JSON_Left)
        {
            //
            // Added 4/5/2020 thomas downes 
            //
            //---Movie m = JsonConvert.DeserializeObject<Movie>(json);

            this.MoveLeft = JsonConvert.DeserializeObject<Moveable_Left>(par_JSON_Left);

        }

        public void SavePositions_Top(string par_JSON_Top)
        {
            //
            // Added 4/5/2020 thomas downes 
            //
            //---Movie m = JsonConvert.DeserializeObject<Movie>(json);

            this.MoveTop = JsonConvert.DeserializeObject<Moveable_Top>(par_JSON_Top);

        }

        public void SavePositions_Width(string par_JSON_Width)
        {
            //
            // Added 4/5/2020 thomas downes 
            //
            //---Movie m = JsonConvert.DeserializeObject<Movie>(json);
            this.MoveWidth = JsonConvert.DeserializeObject<Moveable_Width>(par_JSON_Width);

        }

        public void SavePositions_Height(string par_JSON_Height)
        {
            //
            // Added 4/5/2020 thomas downes 
            //
            //---Movie m = JsonConvert.DeserializeObject<Movie>(json);
            this.MoveHeight = JsonConvert.DeserializeObject<Moveable_Height>(par_JSON_Height);

        }

        public void SavePositions_All(string par_JSON_Left, string par_JSON_Top, 
            string par_JSON_Height, string par_JSON_Width)
        {
            //
            //Added 4/5/2020 thomas downes  
            //
            SavePositions_Left(par_JSON_Left);   // , par_JSON_Top,
            //    par_JSON_width, par_JSON_Height);
            SavePositions_Top(par_JSON_Top);   // , par_JSON_Top,
            SavePositions_Width(par_JSON_Width);   // , par_JSON_Top,
            SavePositions_Height(par_JSON_Height);   // , par_JSON_Top,




        }






    }
}