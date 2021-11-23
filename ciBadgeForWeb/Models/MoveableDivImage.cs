using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Text.JSON;  // Added 3/20/2020 thomas downes
using Newtonsoft.Json;   // Added 3/20/2020 thomas downes
using ciBadgeElements;  // Added 3/20/2020 thomas downes  
using System.Drawing;  // Added 4/22/2020 thomas downes
using System.Collections.Generic;  // Added 11/8/2021 thomas downes 

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
        //====private Dictionary<int, string> mod_listMessages = new Dictionary<int, string>();
        public string[] BugMessages = new string[19 + 1];  // new string[12 + 1];
        public string BugMessageRecent = "";  // Added 11/11/2021 td
        public static string[] Messages = new string[19 + 1]; // Added 11/18/2021 td

        //Added 11/9/2021 thomas downes
        public int CurrentIndexForDropbox = 0;

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

        // Initializ the array. ---3/20/2020 thomas downes 
        //----4/3/2020 td---
        //----private ClassElementField[] mod_arrayElements = new ClassElementField[12 + 1];   // [12];
        private ClassElementField[] mod_arrayElements = new ClassElementField[19 + 1];   // [12];

        private Newtonsoft.Json.JsonConverter mod_converter_Left;
        private Newtonsoft.Json.JsonConverter mod_converter_Top;
        private Newtonsoft.Json.JsonConverter mod_converter_Width;
        private Newtonsoft.Json.JsonConverter mod_converter_Height;

        //Added 4/20/2020 thomas downes
        private Newtonsoft.Json.JsonConverter mod_converter_HasField;
        private Newtonsoft.Json.JsonConverter mod_converter_Displayed;
        private Newtonsoft.Json.JsonConverter mod_converter_FieldNm;

        //
        // Added 4/6/2020 Thomas DOWNES
        //
        public string JSON_Left { get; set; }
        public string JSON_Top { get; set; }
        public string JSON_Width { get; set; }
        public string JSON_Height { get; set; }

        //Added 4/20/2020 thomas downes  
        public string JSON_Offset_Left { get; set; }
        public string JSON_Offset_Top { get; set; }

        //Added 4/20/2020 thomas downes  
        public string JSON_HasField { get; set; }
        public string JSON_Displayed { get; set; }
        public string JSON_FieldNm { get; set; }

        //Number of displayable elements.
        //---public int ElementCount = 12; //Default value is 12. ----4/13/2020 thomas downes
        //---public int ElementCount = 12; //Default value is 12. ----4/13/2020 thomas downes
        public int ElementCount = 19; //Default value is 19. ----11/18/2021 thomas downes

        public Moveable_Left MoveLeft;
        public Moveable_Top MoveTop;

        //Added 4/22/2020 thomas downes
        public Moveable_Left MoveLeft_Offset;
        public Moveable_Top MoveTop_Offset;

        public Moveable_Width MoveWidth;
        public Moveable_Height MoveHeight;

        //Added 4/20/2020 Thomas Downes 
        public Moveable_HasField MoveHasField;
        public Moveable_Displayed MoveDisplayed;
        public Moveable_FieldNm MoveFieldName;

        //Added 5/3/2020 thomas downes
        public Image[] ImageForElement;

        //
        // Initialize. ---3/20/2020 thomas downes 
        //
        public MoveableDivImage(ciBadgeElements.ClassElementsCache_Deprecated par_cache,
                                  System.Drawing.Point par_offsetPoint,
                                  bool par_allStackedUp = false)
        {
            //---April 22, 2020---public MoveableDivImage(ciBadgeElements.ClassElementsCache_Deprecated par_cache)
            //
            // Added 3/20/2020 thomas downes 
            //
            //----11/18/2021---int indexElement = 0;
            int indexElement = -1;
            bool bElementHasField = false;   //Added 4/20/2020 thomas downees 
            bool bElementIsVisible = false;  //Added 4/20/2020 thomas downes 
            bool bFirstVisibleElement = true;  //Rare to default a Boolean to True, but here it is.---11/22/2021 td

            //Added 4/13/2020 thomas downes
            this.MoveTop = new Moveable_Top();
            this.MoveLeft = new Moveable_Left();
            this.MoveWidth = new Moveable_Width();
            this.MoveHeight = new Moveable_Height();

            //Added 4/20/2020 Thomas Downes
            this.MoveHasField = new Moveable_HasField();
            this.MoveDisplayed = new Moveable_Displayed();
            this.MoveFieldName = new Moveable_FieldNm();

            //Added 4/24/2020 thomas downes
            this.MoveTop_Offset = new Moveable_Top();
            this.MoveLeft_Offset = new Moveable_Left();

            //Added 4/13/2020 thomas downes
            this.ElementCount = 0;  // Reinitialize. ---4/13/2020 thomas downes

            //Added 5/3/2020 thomas downes
            var objImageGen = new ciBadgeGenerator.ClassMakeBadge();
            // 5/4/2020 td //ImageForElement = new Image[12];
            // 11/18/2021 td //ImageForElement = new Image[12 + 1]; // We will use 1, 2, ... 12 as the indices. The element # 0 will be ignored. 
            ImageForElement = new Image[19 + 1]; // We will use 0, 1, 2, ... 12 as the indices. The element # 0 will be --INCLUDED--. 
            ClassElementField prior_element = null; //Added 11/22/2021 td

            foreach (ClassElementField each_element in par_cache.ListOfElementFields)
            {
                bElementHasField = true;  //Added 4/20/2020 thomas d.  
                //Added 4/20/2020 thomas d.  
                //bElementIsVisible = each_element.IsDisplayedOnBadge_Visibly();
                WhyOmitted structWhy = new WhyOmitted();
                bElementIsVisible = each_element.IsDisplayedOnBadge_Visibly(ref structWhy);

                //---if (each_element.IsDisplayedOnBadge_Visibly())
                if (bElementIsVisible)
                {
                    indexElement++;

                    //Added 11/18/2021 Thomas downes
                    if (indexElement == 13) continue;  //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields (EL15 to EL19).)
                    if (indexElement == 14) continue;  //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields (EL15 to EL19).)

                    mod_arrayElements[indexElement] = each_element;

                    //Added 4/22/2020 thomas downes
                    const bool c_boolIncludeOffset = true;  //Added 4/22/2020 thomas d.
                    if (c_boolIncludeOffset) //Added 4/22/2020 thomas d.
                    {
                        //Added 4/22/2020 thomas d.
                        //We need to left-align the elements. ----this.MoveLeft_Offset[indexElement] = (par_offsetPoint.X + each_element.LeftEdge_Pixels).ToString() + "px";
                        this.MoveLeft_Offset[indexElement] = (par_offsetPoint.X + 0).ToString() + "px";

                        //We need to stack the elements. ----this.MoveTop_Offset[indexElement] = (par_offsetPoint.Y + each_element.TopEdge_Pixels).ToString() + "px";
                        if (bFirstVisibleElement)
                            this.MoveTop_Offset[indexElement] = ((par_offsetPoint.Y).ToString() + "px");
                        else this.MoveTop_Offset[indexElement] = (par_offsetPoint.Y + 0
                            + prior_element.TopEdge_Pixels + 10
                            + prior_element.Height_Pixels).ToString() + "px";

                        //Moved below.//bFirstVisibleElement = false; // Prepare for next iteration.
                        //Moved below.//prior_element = each_element;  // Prepare for next iteration.

                    }

                    //Added 4/13/2020 thomas downes
                    //We need to left-align the elements. ----this.MoveLeft[indexElement] = each_element.LeftEdge_Pixels.ToString() + "px";
                    this.MoveLeft[indexElement] = "0px";

                    //We need to stack the elements. ----this.MoveTop[indexElement] = each_element.TopEdge_Pixels.ToString() + "px";
                    this.MoveTop[indexElement] = each_element.TopEdge_Pixels.ToString() + "px";
                    if (bFirstVisibleElement)
                        this.MoveTop[indexElement] = "0px";
                    else this.MoveTop[indexElement] = (0
                        + prior_element.TopEdge_Pixels + 10
                        + prior_element.Height_Pixels).ToString() + "px";

                    bFirstVisibleElement = false; // Prepare for next iteration.
                    prior_element = each_element;  // Prepare for next iteration.

                    //Integers are fine, strings not needed. 
                    this.MoveWidth[indexElement] = each_element.Width_Pixels;   //.ToString() + "px";
                    this.MoveHeight[indexElement] = each_element.Height_Pixels;  //.ToString() + "px";

                    //Added 4/20/2020 thomas downes
                    this.MoveDisplayed[indexElement] = bElementIsVisible; // each_element.IsDisplayedOnBadge_Visibly();
                    this.MoveHasField[indexElement] = bElementHasField;  // true;  // each_element.IsDisplayedOnBadge_Visibly();
                    this.MoveFieldName[indexElement] = each_element.FieldInfo.FieldLabelCaption;

                    //Added 5/3/2020 thomas downes 
                    // 11-11-2021 td //this.ImageForElement[indexElement] = objImageGen.ElementFieldToImage(each_element, par_cache.BadgeLayout);
                    string strBugMessage = "";
                    string strTextDisplayed = "";
                    this.ImageForElement[indexElement] =
                        objImageGen.ElementFieldToImage(each_element, par_cache.BadgeLayout,
                                        ref strBugMessage, ref strTextDisplayed);

                    //Added 11/11/2021 thomas downes
                    //===this.BugMessages[indexElement] = this.ImageForElement[indexElement].ToString();
                    this.BugMessages[indexElement] = strBugMessage;
                    this.BugMessageRecent = strBugMessage;

                    //Added 4/13/2020 thomas downes
                    this.ElementCount += 1;  // Increment. ---4/13/2020 thomas downes

                }
            }

            //
            // Fill in the unused values, if needed. 
            //
            //----if (this.ElementCount < 12)
            if (this.ElementCount < 19 + 1)
            {
                //---for (int intEachUnused = +1 + this.ElementCount; intEachUnused <= 12; intEachUnused++)
                for (int intEachUnused = +1 + this.ElementCount; intEachUnused <= 19; intEachUnused++)
                {
                    //Added 11/18/2021 Thomas downes
                    //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed,
                    //  and the five customizable fields (EL15 to EL19).)
                    //   -----11/18/2021 tcd
                    if (intEachUnused == 13) continue;  //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields (EL15 to EL19).)
                    if (intEachUnused == 14) continue;  //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields (EL15 to EL19).)

                    // Added 4/13/2020 thomas downes  
                    this.MoveLeft[intEachUnused] = "0px";  //  "[not applicable]";
                    this.MoveTop[intEachUnused] = "0px";  // "[not applicable]";
                    this.MoveHeight[intEachUnused] = 0;
                    this.MoveWidth[intEachUnused] = 0;

                    // Added 4/20/2020 thomas downes
                    this.MoveHasField[intEachUnused] = false;
                    this.MoveDisplayed[intEachUnused] = false;
                    this.MoveFieldName[intEachUnused] = "";

                    // Added 4/24/2020 thomas downes  
                    this.MoveLeft_Offset[intEachUnused] = "0px";  //  "[not applicable]";
                    this.MoveTop_Offset[intEachUnused] = "0px";  // "[not applicable]";

                }
            }


            //Added 4/13/2020 thomas downes
            this.JSON_Left = this.GetJSON_Left();
            this.JSON_Top = this.GetJSON_Top();
            this.JSON_Height = this.GetJSON_Height();
            this.JSON_Width = this.GetJSON_Width();

            //Added 4/24/2020 thomas downes
            this.JSON_Offset_Left = this.GetJSON_Offset_Left();
            this.JSON_Offset_Top = this.GetJSON_Offset_Top();

            //Added 4/20/2020 thomas downes
            this.JSON_Displayed = this.GetJSON_Displayed();
            this.JSON_HasField = this.GetJSON_HasField();
            this.JSON_FieldNm = this.GetJSON_FieldName();

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

            //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed,
            //  and the five customizable fields (EL15 to EL19).)
            //   -----11/18/2021 tcd
            this.MoveLeft.EL15_Left = (par_moveable.MoveLeft.EL15_Left);
            this.MoveLeft.EL16_Left = (par_moveable.MoveLeft.EL16_Left);
            this.MoveLeft.EL17_Left = (par_moveable.MoveLeft.EL17_Left);
            this.MoveLeft.EL18_Left = (par_moveable.MoveLeft.EL18_Left);
            this.MoveLeft.EL19_Left = (par_moveable.MoveLeft.EL19_Left);

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

            //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed,
            //  and the five customizable fields (EL15 to EL19).)
            //   -----11/18/2021 tcd
            this.MoveTop.EL15_Top = (par_moveable.MoveTop.EL15_Top);
            this.MoveTop.EL16_Top = (par_moveable.MoveTop.EL16_Top);
            this.MoveTop.EL17_Top = (par_moveable.MoveTop.EL17_Top);
            this.MoveTop.EL18_Top = (par_moveable.MoveTop.EL18_Top);
            this.MoveTop.EL19_Top = (par_moveable.MoveTop.EL19_Top);

            //Added 4/20/2020 thomas downes
            this.MoveWidth.EL1_Width = (par_moveable.MoveWidth.EL1_Width);
            this.MoveWidth.EL2_Width = (par_moveable.MoveWidth.EL2_Width);
            this.MoveWidth.EL3_Width = (par_moveable.MoveWidth.EL3_Width);
            this.MoveWidth.EL4_Width = (par_moveable.MoveWidth.EL4_Width);
            this.MoveWidth.EL5_Width = (par_moveable.MoveWidth.EL5_Width);
            this.MoveWidth.EL6_Width = (par_moveable.MoveWidth.EL6_Width);
            this.MoveWidth.EL7_Width = (par_moveable.MoveWidth.EL7_Width);
            this.MoveWidth.EL8_Width = (par_moveable.MoveWidth.EL8_Width);
            this.MoveWidth.EL9_Width = (par_moveable.MoveWidth.EL9_Width);
            this.MoveWidth.EL10_Width = (par_moveable.MoveWidth.EL10_Width);
            this.MoveWidth.EL11_Width = (par_moveable.MoveWidth.EL11_Width);
            this.MoveWidth.EL12_Width = (par_moveable.MoveWidth.EL12_Width);

            //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed,
            //  and the five customizable fields (EL15 to EL19).)
            //   -----11/18/2021 tcd
            this.MoveWidth.EL15_Width = (par_moveable.MoveWidth.EL15_Width);
            this.MoveWidth.EL16_Width = (par_moveable.MoveWidth.EL16_Width);
            this.MoveWidth.EL17_Width = (par_moveable.MoveWidth.EL17_Width);
            this.MoveWidth.EL18_Width = (par_moveable.MoveWidth.EL18_Width);
            this.MoveWidth.EL19_Width = (par_moveable.MoveWidth.EL19_Width);

            //Added 4/20/2020 thomas downes
            this.MoveHeight.EL1_Height = (par_moveable.MoveHeight.EL1_Height);
            this.MoveHeight.EL2_Height = (par_moveable.MoveHeight.EL2_Height);
            this.MoveHeight.EL3_Height = (par_moveable.MoveHeight.EL3_Height);
            this.MoveHeight.EL4_Height = (par_moveable.MoveHeight.EL4_Height);
            this.MoveHeight.EL5_Height = (par_moveable.MoveHeight.EL5_Height);
            this.MoveHeight.EL6_Height = (par_moveable.MoveHeight.EL6_Height);
            this.MoveHeight.EL7_Height = (par_moveable.MoveHeight.EL7_Height);
            this.MoveHeight.EL8_Height = (par_moveable.MoveHeight.EL8_Height);
            this.MoveHeight.EL9_Height = (par_moveable.MoveHeight.EL9_Height);
            this.MoveHeight.EL10_Height = (par_moveable.MoveHeight.EL10_Height);
            this.MoveHeight.EL11_Height = (par_moveable.MoveHeight.EL11_Height);
            this.MoveHeight.EL12_Height = (par_moveable.MoveHeight.EL12_Height);

            //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed,
            //  and the five customizable fields (EL15 to EL19).)
            //   -----11/18/2021 tcd
            this.MoveHeight.EL15_Height = (par_moveable.MoveHeight.EL15_Height);
            this.MoveHeight.EL16_Height = (par_moveable.MoveHeight.EL16_Height);
            this.MoveHeight.EL17_Height = (par_moveable.MoveHeight.EL17_Height);
            this.MoveHeight.EL18_Height = (par_moveable.MoveHeight.EL18_Height);
            this.MoveHeight.EL19_Height = (par_moveable.MoveHeight.EL19_Height);

            //Added 4/20/2020 thomas downes
            this.MoveDisplayed.EL1_Displayed = (par_moveable.MoveDisplayed.EL1_Displayed);
            this.MoveDisplayed.EL2_Displayed = (par_moveable.MoveDisplayed.EL2_Displayed);
            this.MoveDisplayed.EL3_Displayed = (par_moveable.MoveDisplayed.EL3_Displayed);
            this.MoveDisplayed.EL4_Displayed = (par_moveable.MoveDisplayed.EL4_Displayed);
            this.MoveDisplayed.EL5_Displayed = (par_moveable.MoveDisplayed.EL5_Displayed);
            this.MoveDisplayed.EL6_Displayed = (par_moveable.MoveDisplayed.EL6_Displayed);
            this.MoveDisplayed.EL7_Displayed = (par_moveable.MoveDisplayed.EL7_Displayed);
            this.MoveDisplayed.EL8_Displayed = (par_moveable.MoveDisplayed.EL8_Displayed);
            this.MoveDisplayed.EL9_Displayed = (par_moveable.MoveDisplayed.EL9_Displayed);
            this.MoveDisplayed.EL10_Displayed = (par_moveable.MoveDisplayed.EL10_Displayed);
            this.MoveDisplayed.EL11_Displayed = (par_moveable.MoveDisplayed.EL11_Displayed);
            this.MoveDisplayed.EL12_Displayed = (par_moveable.MoveDisplayed.EL12_Displayed);

            //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed,
            //  and the five customizable fields (EL15 to EL19).)
            //   -----11/18/2021 tcd
            this.MoveDisplayed.EL15_Displayed = (par_moveable.MoveDisplayed.EL15_Displayed);
            this.MoveDisplayed.EL16_Displayed = (par_moveable.MoveDisplayed.EL16_Displayed);
            this.MoveDisplayed.EL17_Displayed = (par_moveable.MoveDisplayed.EL17_Displayed);
            this.MoveDisplayed.EL18_Displayed = (par_moveable.MoveDisplayed.EL18_Displayed);
            this.MoveDisplayed.EL19_Displayed = (par_moveable.MoveDisplayed.EL19_Displayed);

            //Added 4/20/2020 thomas downes
            this.MoveHasField.EL1_HasField = (par_moveable.MoveHasField.EL1_HasField);
            this.MoveHasField.EL2_HasField = (par_moveable.MoveHasField.EL2_HasField);
            this.MoveHasField.EL3_HasField = (par_moveable.MoveHasField.EL3_HasField);
            this.MoveHasField.EL4_HasField = (par_moveable.MoveHasField.EL4_HasField);
            this.MoveHasField.EL5_HasField = (par_moveable.MoveHasField.EL5_HasField);
            this.MoveHasField.EL6_HasField = (par_moveable.MoveHasField.EL6_HasField);
            this.MoveHasField.EL7_HasField = (par_moveable.MoveHasField.EL7_HasField);
            this.MoveHasField.EL8_HasField = (par_moveable.MoveHasField.EL8_HasField);
            this.MoveHasField.EL9_HasField = (par_moveable.MoveHasField.EL9_HasField);
            this.MoveHasField.EL10_HasField = (par_moveable.MoveHasField.EL10_HasField);
            this.MoveHasField.EL11_HasField = (par_moveable.MoveHasField.EL11_HasField);
            this.MoveHasField.EL12_HasField = (par_moveable.MoveHasField.EL12_HasField);

            //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed,
            //  and the five customizable fields (EL15 to EL19).)
            //   -----11/18/2021 tcd
            this.MoveHasField.EL15_HasField = (par_moveable.MoveHasField.EL15_HasField);
            this.MoveHasField.EL16_HasField = (par_moveable.MoveHasField.EL16_HasField);
            this.MoveHasField.EL17_HasField = (par_moveable.MoveHasField.EL17_HasField);
            this.MoveHasField.EL18_HasField = (par_moveable.MoveHasField.EL18_HasField);
            this.MoveHasField.EL19_HasField = (par_moveable.MoveHasField.EL19_HasField);

            //Added 4/20/2020 thomas downes
            this.MoveFieldName.EL1_FieldNm = (par_moveable.MoveFieldName.EL1_FieldNm);
            this.MoveFieldName.EL2_FieldNm = (par_moveable.MoveFieldName.EL2_FieldNm);
            this.MoveFieldName.EL3_FieldNm = (par_moveable.MoveFieldName.EL3_FieldNm);
            this.MoveFieldName.EL4_FieldNm = (par_moveable.MoveFieldName.EL4_FieldNm);
            this.MoveFieldName.EL5_FieldNm = (par_moveable.MoveFieldName.EL5_FieldNm);
            this.MoveFieldName.EL6_FieldNm = (par_moveable.MoveFieldName.EL6_FieldNm);
            this.MoveFieldName.EL7_FieldNm = (par_moveable.MoveFieldName.EL7_FieldNm);
            this.MoveFieldName.EL8_FieldNm = (par_moveable.MoveFieldName.EL8_FieldNm);
            this.MoveFieldName.EL9_FieldNm = (par_moveable.MoveFieldName.EL9_FieldNm);
            this.MoveFieldName.EL10_FieldNm = (par_moveable.MoveFieldName.EL10_FieldNm);
            this.MoveFieldName.EL11_FieldNm = (par_moveable.MoveFieldName.EL11_FieldNm);
            this.MoveFieldName.EL12_FieldNm = (par_moveable.MoveFieldName.EL12_FieldNm);

            //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed,
            //  and the five customizable fields (EL15 to EL19).)
            //   -----11/18/2021 tcd
            this.MoveFieldName.EL15_FieldNm = (par_moveable.MoveFieldName.EL15_FieldNm);
            this.MoveFieldName.EL16_FieldNm = (par_moveable.MoveFieldName.EL16_FieldNm);
            this.MoveFieldName.EL17_FieldNm = (par_moveable.MoveFieldName.EL17_FieldNm);
            this.MoveFieldName.EL18_FieldNm = (par_moveable.MoveFieldName.EL18_FieldNm);
            this.MoveFieldName.EL19_FieldNm = (par_moveable.MoveFieldName.EL19_FieldNm);

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

            //json_options.Formatting = Formatting.Indented;
            json_options.Formatting = Formatting.None;

            // 4-5-2020 TD//mod_converter_Left = JsonConvert.SerializeObject(this.MoveLeft, this.MoveLeft.GetType(), json_options );
            // 4-5-2020 TD//mod_converter_Left = new JsonConverter<Moveable_Left>()
            // 4-5-2020 TD//string strOutput = JsonConvert.SerializeObject(this.MoveLeft, this.MoveLeft.GetType(), json_options);

            //ADded 4/16/2020 tdownes
            if (this.MoveLeft.EL1_Left == null) this.MoveLeft.EL1_Left = "0px";
            if (this.MoveLeft.EL2_Left == null) this.MoveLeft.EL2_Left = "0px";
            if (this.MoveLeft.EL3_Left == null) this.MoveLeft.EL3_Left = "0px";
            if (this.MoveLeft.EL4_Left == null) this.MoveLeft.EL4_Left = "0px";
            if (this.MoveLeft.EL5_Left == null) this.MoveLeft.EL5_Left = "0px";
            if (this.MoveLeft.EL6_Left == null) this.MoveLeft.EL6_Left = "0px";
            if (this.MoveLeft.EL7_Left == null) this.MoveLeft.EL7_Left = "0px";
            if (this.MoveLeft.EL8_Left == null) this.MoveLeft.EL8_Left = "0px";
            if (this.MoveLeft.EL9_Left == null) this.MoveLeft.EL9_Left = "0px";
            if (this.MoveLeft.EL10_Left == null) this.MoveLeft.EL10_Left = "0px";
            if (this.MoveLeft.EL11_Left == null) this.MoveLeft.EL11_Left = "0px";
            if (this.MoveLeft.EL12_Left == null) this.MoveLeft.EL12_Left = "0px";

            //
            // Customizable fields.
            //
            //Added 11/18/2021 Thomas downes
            //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed,
            //  and the five customizable fields (EL15 to EL19).)
            //   -----11/18/2021 tcd
            //
            if (this.MoveLeft.EL15_Left == null) this.MoveLeft.EL15_Left = "0px";
            if (this.MoveLeft.EL16_Left == null) this.MoveLeft.EL16_Left = "0px";
            if (this.MoveLeft.EL17_Left == null) this.MoveLeft.EL17_Left = "0px";
            if (this.MoveLeft.EL18_Left == null) this.MoveLeft.EL18_Left = "0px";
            if (this.MoveLeft.EL19_Left == null) this.MoveLeft.EL19_Left = "0px";
            //if (this.MoveLeft.EL20_Left == null) this.MoveLeft.EL20_Left = "0px";

            string strOutput = JsonConvert.SerializeObject(this.MoveLeft);

            return strOutput;

        }

        public string GetJSON_Top()
        {
            //
            // Added 4/3/2020 thomas downes
            //
            JsonSerializerSettings json_options = new JsonSerializerSettings();
            //json_options.Formatting = Formatting.Indented;
            json_options.Formatting = Formatting.None;

            //ADded 4/16/2020 tdownes
            if (this.MoveTop.EL1_Top == null) this.MoveTop.EL1_Top = "0px";
            if (this.MoveTop.EL2_Top == null) this.MoveTop.EL2_Top = "0px";
            if (this.MoveTop.EL3_Top == null) this.MoveTop.EL3_Top = "0px";
            if (this.MoveTop.EL4_Top == null) this.MoveTop.EL4_Top = "0px";
            if (this.MoveTop.EL5_Top == null) this.MoveTop.EL5_Top = "0px";
            if (this.MoveTop.EL6_Top == null) this.MoveTop.EL6_Top = "0px";
            if (this.MoveTop.EL7_Top == null) this.MoveTop.EL7_Top = "0px";
            if (this.MoveTop.EL8_Top == null) this.MoveTop.EL8_Top = "0px";
            if (this.MoveTop.EL9_Top == null) this.MoveTop.EL9_Top = "0px";
            if (this.MoveTop.EL10_Top == null) this.MoveTop.EL10_Top = "0px";
            if (this.MoveTop.EL11_Top == null) this.MoveTop.EL11_Top = "0px";
            if (this.MoveTop.EL12_Top == null) this.MoveTop.EL12_Top = "0px";

            //
            // Customizable fields.
            //
            //Added 11/18/2021 Thomas downes
            //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed,
            //  and the five customizable fields (EL15 to EL19).)
            //   -----11/18/2021 tcd
            //
            if (this.MoveTop.EL15_Top == null) this.MoveTop.EL15_Top = "0px";
            if (this.MoveTop.EL16_Top == null) this.MoveTop.EL16_Top = "0px";
            if (this.MoveTop.EL17_Top == null) this.MoveTop.EL17_Top = "0px";
            if (this.MoveTop.EL18_Top == null) this.MoveTop.EL18_Top = "0px";
            if (this.MoveTop.EL19_Top == null) this.MoveTop.EL19_Top = "0px";
            //if (this.MoveTop.EL20_Top == null) this.MoveTop.EL20_Top = "0px";

            string strOutput = JsonConvert.SerializeObject(this.MoveTop, this.MoveTop.GetType(), json_options);

            return strOutput;

        }

        public string GetJSON_Offset_Left()
        {
            //
            // Added 4/3/2020 thomas downes
            //
            JsonSerializerSettings json_options = new JsonSerializerSettings();

            json_options.Formatting = Formatting.None;

            if (this.MoveLeft_Offset.EL1_Left == null) this.MoveLeft_Offset.EL1_Left = "0px";
            if (this.MoveLeft_Offset.EL2_Left == null) this.MoveLeft_Offset.EL2_Left = "0px";
            if (this.MoveLeft_Offset.EL3_Left == null) this.MoveLeft_Offset.EL3_Left = "0px";
            if (this.MoveLeft_Offset.EL4_Left == null) this.MoveLeft_Offset.EL4_Left = "0px";
            if (this.MoveLeft_Offset.EL5_Left == null) this.MoveLeft_Offset.EL5_Left = "0px";
            if (this.MoveLeft_Offset.EL6_Left == null) this.MoveLeft_Offset.EL6_Left = "0px";
            if (this.MoveLeft_Offset.EL7_Left == null) this.MoveLeft_Offset.EL7_Left = "0px";
            if (this.MoveLeft_Offset.EL8_Left == null) this.MoveLeft_Offset.EL8_Left = "0px";
            if (this.MoveLeft_Offset.EL9_Left == null) this.MoveLeft_Offset.EL9_Left = "0px";
            if (this.MoveLeft_Offset.EL10_Left == null) this.MoveLeft_Offset.EL10_Left = "0px";
            if (this.MoveLeft_Offset.EL11_Left == null) this.MoveLeft_Offset.EL11_Left = "0px";
            if (this.MoveLeft_Offset.EL12_Left == null) this.MoveLeft_Offset.EL12_Left = "0px";

            //
            // Customizable fields.
            //
            if (this.MoveLeft_Offset.EL15_Left == null) this.MoveLeft_Offset.EL15_Left = "0px";
            if (this.MoveLeft_Offset.EL16_Left == null) this.MoveLeft_Offset.EL16_Left = "0px";
            if (this.MoveLeft_Offset.EL17_Left == null) this.MoveLeft_Offset.EL17_Left = "0px";
            if (this.MoveLeft_Offset.EL18_Left == null) this.MoveLeft_Offset.EL18_Left = "0px";
            if (this.MoveLeft_Offset.EL19_Left == null) this.MoveLeft_Offset.EL19_Left = "0px";
            //if (this.MoveLeft_Offset.EL20_Left == null) this.MoveLeft_Offset.EL20_Left = "0px";

            // 4-22-2020 td//string strOutput = JsonConvert.SerializeObject(this.MoveLeft_Offset);
            string strOutput = JsonConvert.SerializeObject(this.MoveLeft_Offset, this.MoveLeft_Offset.GetType(), json_options);

            return strOutput;

        }

        public string GetJSON_Offset_Top()
        {
            //
            // Added 4/22/2020 thomas downes
            //
            JsonSerializerSettings json_options = new JsonSerializerSettings();
            //json_options.Formatting = Formatting.Indented;
            json_options.Formatting = Formatting.None;

            //ADded 4/16/2020 tdownes
            if (this.MoveTop_Offset.EL1_Top == null) this.MoveTop_Offset.EL1_Top = "0px";
            if (this.MoveTop_Offset.EL2_Top == null) this.MoveTop_Offset.EL2_Top = "0px";
            if (this.MoveTop_Offset.EL3_Top == null) this.MoveTop_Offset.EL3_Top = "0px";
            if (this.MoveTop_Offset.EL4_Top == null) this.MoveTop_Offset.EL4_Top = "0px";
            if (this.MoveTop_Offset.EL5_Top == null) this.MoveTop_Offset.EL5_Top = "0px";
            if (this.MoveTop_Offset.EL6_Top == null) this.MoveTop_Offset.EL6_Top = "0px";
            if (this.MoveTop_Offset.EL7_Top == null) this.MoveTop_Offset.EL7_Top = "0px";
            if (this.MoveTop_Offset.EL8_Top == null) this.MoveTop_Offset.EL8_Top = "0px";
            if (this.MoveTop_Offset.EL9_Top == null) this.MoveTop_Offset.EL9_Top = "0px";
            if (this.MoveTop_Offset.EL10_Top == null) this.MoveTop_Offset.EL10_Top = "0px";
            if (this.MoveTop_Offset.EL11_Top == null) this.MoveTop_Offset.EL11_Top = "0px";
            if (this.MoveTop_Offset.EL12_Top == null) this.MoveTop_Offset.EL12_Top = "0px";

            //
            // Customizable fields.
            //
            if (this.MoveTop_Offset.EL15_Top == null) this.MoveTop_Offset.EL15_Top = "0px";
            if (this.MoveTop_Offset.EL16_Top == null) this.MoveTop_Offset.EL16_Top = "0px";
            if (this.MoveTop_Offset.EL17_Top == null) this.MoveTop_Offset.EL17_Top = "0px";
            if (this.MoveTop_Offset.EL18_Top == null) this.MoveTop_Offset.EL18_Top = "0px";
            if (this.MoveTop_Offset.EL19_Top == null) this.MoveTop_Offset.EL19_Top = "0px";
            //if (this.MoveTop_Offset.EL20_Top == null) this.MoveTop_Offset.EL20_Top = "0px";


            string strOutput = JsonConvert.SerializeObject(this.MoveTop_Offset, this.MoveTop_Offset.GetType(), json_options);

            return strOutput;

        }

        public string GetJSON_Width()
        {
            //
            // Added 4/3/2020 thomas downes
            //
            JsonSerializerSettings json_options = new JsonSerializerSettings();
            //json_options.Formatting = Formatting.Indented;
            json_options.Formatting = Formatting.None;

            string strOutput = JsonConvert.SerializeObject(this.MoveWidth, this.MoveWidth.GetType(), json_options);
            return strOutput;

        }

        public string GetJSON_Height()
        {
            //
            // Added 4/3/2020 thomas downes
            //
            JsonSerializerSettings json_options = new JsonSerializerSettings();
            //---json_options.Formatting = Formatting.Indented;
            json_options.Formatting = Formatting.None;
            string strOutput = JsonConvert.SerializeObject(this.MoveHeight, this.MoveHeight.GetType(), json_options);
            return strOutput;

        }

        public string GetJSON_Displayed()
        {
            //
            // Added 4/20/2020 thomas downes
            //
            JsonSerializerSettings json_options = new JsonSerializerSettings();
            //json_options.Formatting = Formatting.Indented;
            json_options.Formatting = Formatting.None;
            string strOutput = JsonConvert.SerializeObject(this.MoveDisplayed, this.MoveDisplayed.GetType(), json_options);
            return strOutput;

        }

        public string GetJSON_HasField()
        {
            //
            // Added 4/20/2020 thomas downes
            //
            JsonSerializerSettings json_options = new JsonSerializerSettings();
            //json_options.Formatting = Formatting.Indented;
            json_options.Formatting = Formatting.None;
            string strOutput = JsonConvert.SerializeObject(this.MoveHasField, this.MoveHasField.GetType(), json_options);
            return strOutput;

        }

        public string GetJSON_FieldName()
        {
            // Added 4/20/2020 thomas downes
            JsonSerializerSettings json_options = new JsonSerializerSettings();
            //json_options.Formatting = Formatting.Indented;
            json_options.Formatting = Formatting.None;
            string strOutput = JsonConvert.SerializeObject(this.MoveHasField, this.MoveHasField.GetType(), json_options);
            return strOutput;

        }

        public void SavePositions_Left(string par_JSON_Left, bool par_bHasOffsets)
        {
            //
            // Added 4/5/2020 thomas downes 
            //
            //---Movie m = JsonConvert.DeserializeObject<Movie>(json);

            if (par_bHasOffsets)
            {
                this.MoveLeft_Offset = JsonConvert.DeserializeObject<Moveable_Left>(par_JSON_Left);
                //Added 4/22/2020 thomas d.
                //-----this.MoveLeft.Refresh_MinusOffsets(this.MoveLeft_Offset);
                this.MoveLeft.RefreshMe_MinusOffsets(this.MoveLeft_Offset, Controllers.JsonFileController.OffsetPoint);
            }
            else
            {
                this.MoveLeft = JsonConvert.DeserializeObject<Moveable_Left>(par_JSON_Left);
            }

        }

        public void SavePositions_Top(string par_JSON_Top, bool par_bHasOffsets)
        {
            //
            // Added 4/5/2020 thomas downes 
            //
            //---Movie m = JsonConvert.DeserializeObject<Movie>(json);

            // 4-22/2020 td //this.MoveTop = JsonConvert.DeserializeObject<Moveable_Top>(par_JSON_Top);
            if (par_bHasOffsets)
            {
                this.MoveTop_Offset = JsonConvert.DeserializeObject<Moveable_Top>(par_JSON_Top);
                //Added 4/22/2020 thomas d.
                //-----this.MoveTop.Refresh_MinusOffsets(this.MoveTop_Offset, OffsetPoint);
                this.MoveTop.RefreshMe_MinusOffsets(this.MoveTop_Offset, Controllers.JsonFileController.OffsetPoint);
            }
            else
            {
                this.MoveTop = JsonConvert.DeserializeObject<Moveable_Top>(par_JSON_Top);
            }

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
            string par_JSON_Height, string par_JSON_Width, bool par_bAccountForOffsets)
        {
            //
            //Added 4/5/2020 thomas downes  
            //
            SavePositions_Left(par_JSON_Left, par_bAccountForOffsets);   // , par_JSON_Top,
            //    par_JSON_width, par_JSON_Height);
            SavePositions_Top(par_JSON_Top, par_bAccountForOffsets);   // , par_JSON_Top,
            SavePositions_Width(par_JSON_Width);   // , par_JSON_Top,
            SavePositions_Height(par_JSON_Height);   // , par_JSON_Top,

        }

        public void SavePositions_ToCache()
        {
            //
            // Added 4/16/2020 thomas downes
            //
            //-----for (int i_indexElement = 0; i_indexElement < 12; i_indexElement++)
            //====for (int i_indexElement = 1; i_indexElement <= 12; i_indexElement++)
            for (int i_indexElement = 1; i_indexElement <= 19; i_indexElement++)
            {
                //Added 11/18/2021 Thomas downes
                //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed,
                //  and the five customizable fields (EL15 to EL19).)
                //   -----11/18/2021 tcd
                if (i_indexElement == 13) continue;  //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields (EL15 to EL19).)
                if (i_indexElement == 14) continue;  //There is a gap between the 12(+1 for 0th) Standard fields being possibly displayed, and the five customizable fields (EL15 to EL19).)

                //
                // We will check to see if the Element has a positive (non-zero) width,
                //   in order to know that the Element is a viable & needed Element
                //   which is important to the Badge. ----4/16/2020 td
                //
                if (this.MoveWidth[i_indexElement] > 0)
                {
                    try
                    {
                        mod_arrayElements[i_indexElement].LeftEdge_Pixels = int.Parse(this.MoveLeft[i_indexElement].Replace("px", ""));
                        mod_arrayElements[i_indexElement].TopEdge_Pixels = int.Parse(this.MoveTop[i_indexElement].Replace("px", ""));
                        mod_arrayElements[i_indexElement].Width_Pixels = this.MoveWidth[i_indexElement];
                        mod_arrayElements[i_indexElement].Height_Pixels = this.MoveHeight[i_indexElement];
                    }
                    catch (Exception ex)
                    {
                        //Added 4/16/2020 td 
                        System.Diagnostics.Debugger.Break();
                        throw;
                    }
                }
            }

            //
            // Execute a general save operation on the cache's 
            //    XML file. 
            //
            //--Controllers.PersonalityController.CurrentPersonality.Cache.Save(); 
            ClassElementsCache_Deprecated.Singleton.SaveToXML();

        }


        public Point GetOffsetPoint()
        {
            //Added 4/24/2020 thomas downes
            return Controllers.JsonFileController.OffsetPoint;

        }

        public string GetOffsetPixels_Left()
        {
            //Added 4/24/2020 thomas downes
            return (Controllers.JsonFileController.OffsetPoint.X.ToString() + "px");

        }

        public string GetOffsetPixels_Top()
        {
            //Added 4/24/2020 thomas downes
            return (Controllers.JsonFileController.OffsetPoint.Y.ToString() + "px");

        }


        public string GetImageString_Base64(int par_index)
        {
            //=====public string GetImageString_Base64(int par_index, ref string par_strMessage)
            //----public string GetImageString_Base64(int par_index)
            //
            //Added 5/3/2 020 thomas downes  
            //
            Image imageByIndex = this.ImageForElement[par_index];

            //Added 11/8/2021 Thomas Downes
            //string strMessage = "";
            if (imageByIndex == null) BugMessages[par_index] = "Image is null.";
            else if (25 > imageByIndex.Size.Width) BugMessages[par_index] = "Image is less than 25-in-width.";
            else if (25 > imageByIndex.Size.Height) BugMessages[par_index] = "Image is less than 25-in-height.";
            else BugMessages[par_index] = "";

            //
            //  https://stackoverflow.com/questions/8499633/how-to-display-base64-images-in-html
            //
            const string SRC_PREFIX_FOR_BASE64_1 = "data:image/png;base64, ";
            const string SRC_PREFIX_FOR_BASE64_2 = "data: image / jpeg; base64,";

            //---return (SRC_PREFIX_FOR_BASE64_2 + GetBase64(imageByIndex));
            return (SRC_PREFIX_FOR_BASE64_2 + GetBase64String_FromImage(imageByIndex));

        }

        private string GetBase64String_FromImage(Image par_image)
        {
            //---private string GetBase64(Image par_image)
            //
            // How to convert image to byte array
            //  https://stackoverflow.com/questions/3801275/how-to-convert-image-to-byte-array
            //
            ImageConverter _imageConverter = new ImageConverter();
            byte[] bytearrayOfImage = (byte[])_imageConverter.ConvertTo(par_image, typeof(byte[]));
            //return xByte;
            return Convert.ToBase64String(bytearrayOfImage);
        }

        private string GetBase64_PresentationCore(Image par_image)
        {
            //
            //   Conversion from image to base64, System.drawing.image
            //   https://stackoverflow.com/questions/23707033/conversion-from-image-to-base64-system-drawing-image
            //  
            byte[] bytearrayOfImage = null;
            using (System.IO.MemoryStream ms_MemoryStream = new System.IO.MemoryStream())
            {
                //var wb_Bitmap = new WriteableBitmap((BitmapImage)par_image.Source);
                //wb_Bitmap.SaveJpeg(ms_MemoryStream, wb_Bitmap.PixelWidth, wb_Bitmap.PixelHeight, 0, 100);
                //bytearrayOfImage = ms_MemoryStream.ToArray();
            }
            return Convert.ToBase64String(bytearrayOfImage);

        }


    }
}