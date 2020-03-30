using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.Mvc; //Added 3/20/2020 td
using System.ComponentModel.DataAnnotations; //Added 3/20/2020 td
using System.IO;   //Added 3/21/2020 thomas downes  

namespace ciBadgeForWeb.Models
{
    //
    // Added 3/20/2020 thomas downes  
    //
    public class JsonFile
    {
        //
        // Added 3/20/2020 thomas downes  
        //
        [Key]
        public int JsonFileID { get; set; }

        //Added 3/21/2020 thomas downes
        //private string mod_JsonTextContent = "{\"Element4_Top\":\"352px\",\"Element4_Width\":\"532px\",\"Element3_Top\":\"352px\",\"Element3_Left\":\"314px\",\"Element6_Top\":\"351px\",\"Element6_Left\":\"91px\",\"Element5_Top\":\"496px\",\"Element5_Left\":\"87px\",\"Element2_Top\":\"499px\",\"Element2_Left\":\"313px\",\"Element1_Top\":\"499px\",\"Element1_Left\":\"535px\",\"Element9_Top\":\"400px\",\"Element9_Left\":\"88px\",\"Element8_Top\":\"448px\",\"Element8_Left\":\"87px\",\"Element10_Top\":\"403px\",\"Element10_Left\":\"314px\",\"Element11_Top\":\"451px\",\"Element11_Left\":\"314px\",\"Element12_Top\":\"404px\",\"Element12_Left\":\"533px\",\"Element7_Top\":\"454px\",\"Element7_Left\":\"535px\"}";
        private string mod_JsonTextContent_Left = "{ \"EL1_Left\":\"532px\", \"EL2_Left\":\"314px\", \"EL3_Left\":\"91px\", \"EL4_Left\":\"87px\",  \"EL5_Left\":\"313px\",  \"EL6_Left\":\"499px\",  \"EL7_Left\":\"88px\",  \"EL8_Left\":\"87px\",   \"EL9_Left\":\"314px\",  \"EL10_Left\":\"314px\",  \"EL11_Left\":\"533px\",  \"EL12_Left\":\"535px\"  }";
        private string mod_JsonTextContent_Top = "{ \"EL1_Top\":\"352px\",  \"EL2_Top\":\"352px\",  \"EL3_Top\":\"351px\",  \"EL4_Top\":\"496px\",  \"EL5_Top\":\"499px\",   \"EL6_Top\":\"499px\",   \"EL7_Top\":\"400px\",  \"EL8_Top\":\"448px\",   \"EL9_Top\":\"403px\",   \"EL10_Top\":\"451px\",   \"EL11_Top\":\"404px\",   \"EL12_Top\":\"454px\"   }";

        //Added 3/26/2020 thomas downes
        //----private string mod_JsonTextContent_Width =  "{ \"EL4_Width\":\"200px\",  \"EL3_Width\":\"200px\",  \"EL6_Width\":\"200px\",  \"EL5_Width\":\"200px\",  \"EL2_Width\":\"200px\",   \"EL1_Width\":\"200px\",   \"EL9_Width\":\"200px\",  \"EL8_Width\":\"200px\",  \"EL10_Width\":\"200px\",   \"EL11_Width\":\"200px\",   \"EL12_Width\":\"200px\",   \"EL7_Width\":\"200px\"  }";
        //---private string mod_JsonTextContent_Height = "{ \"EL4_Height\":\"35px\",  \"EL3_Height\":\"35px\",  \"EL6_Height\":\"35px\",  \"EL5_Height\":\"35px\",  \"EL2_Height\":\"35px\",   \"EL1_Height\":\"35px\",   \"EL9_Height\":\"35px\",  \"EL8_Height\":\"35px\",  \"EL10_Height\":\"35px\",   \"EL11_Height\":\"35px\",   \"EL12_Height\":\"35px\",   \"EL7_Height\":\"35px\"  }";
        private string mod_JsonTextContent_Width = "{ \"EL1_Width\":\"150\",  \"EL2_Width\":\"150\",  \"EL3_Width\":\"200\",  \"EL4_Width\":\"200\",  \"EL5_Width\":\"200\",   \"EL6_Width\":\"200\",   \"EL7_Width\":\"200\",  \"EL8_Width\":\"200\",  \"EL9_Width\":\"200\",   \"EL10_Width\":\"200\",   \"EL11_Width\":\"200\",   \"EL12_Width\":\"200\"  }";
        private string mod_JsonTextContent_Height = "{ \"EL1_Height\":\"35\",  \"EL2_Height\":\"35\",  \"EL3_Height\":\"35\",  \"EL4_Height\":\"35\",  \"EL5_Height\":\"35\",   \"EL6_Height\":\"35\",   \"EL7_Height\":\"35\",  \"EL8_Height\":\"35\",  \"EL9_Height\":\"35\",   \"EL10_Height\":\"35\",   \"EL11_Height\":\"35\",   \"EL12_Height\":\"35\"  }";


        public string JsonTextContent_Left {
            //
            // Suffixed/renamed from "JsonTextContent" on 3/22/2020 thomas downes
            //
            //
            //
            get
            {
                //Added 3/21/2020 thomas downes
                return mod_JsonTextContent_Left;
            }
            set
            {
                //Added 3/21/2020 thomas downes
                mod_JsonTextContent_Left = value;
            }
        }

        public string JsonTextContent_Top
        {
            //
            // Added 3/22/2020 thomas downes
            //
            get
            {
                //Added 3/22/2020 thomas downes
                return mod_JsonTextContent_Top;
            }
            set
            {
                //Added 3/22/2020 thomas downes
                mod_JsonTextContent_Top = value;
            }
        }

        public string JsonTextContent_Width
        {
            //
            // Added 3/26/2020 thomas downes
            //
            get
            {
                //Added 3/26/2020 thomas downes
                return mod_JsonTextContent_Width;
            }
            set
            {
                //Added 3/26/2020 thomas downes
                mod_JsonTextContent_Width = value;
            }
        }

        public string JsonTextContent_Height
        {
            //
            // Added 3/26/2020 thomas downes
            //
            get
            {
                //Added 3/26/2020 thomas downes
                return mod_JsonTextContent_Height;
            }
            set
            {
                //Added 3/26/2020 thomas downes
                mod_JsonTextContent_Height = value;
            }
        }

        // 3-24-2020 td// public string FullPathToFile { get; set; }
        public string FullPathToFile_Left { get; set; }
        public string FullPathToFile_Top { get; set; }

        //Added 3/29/2020 thomas downes
        public string FullPathToFile_Width { get; set; }
        public string FullPathToFile_Height { get; set; }

        public string NameOfClassType { get; set;  }

        public JsonFile()
        {
            //
            // Added 3/21/2020 Thomas Downes  
            //
            // 3-24-2020 td//string strFullPathToJsonFile;
            string strFullPathToJsonFile_Left;
            string strFullPathToJsonFile_Top;

            string strFullPathToJsonFile_Width;    // Added 3/29/2020 thomas downes
            string strFullPathToJsonFile_Height;   // Added 3/29/2020 thomas downes

            ///
            // Get the JSON file.  
            //
            // 3-24-2020 td//strFullPathToJsonFile = ciBadgeForWeb.App_Start.DiskFiles.PathToFile_JSON_Current(true);
            strFullPathToJsonFile_Left = ciBadgeForWeb.App_Start.DiskFiles.PathToFile_JSON_Current(true, "_Left");
            strFullPathToJsonFile_Top = ciBadgeForWeb.App_Start.DiskFiles.PathToFile_JSON_Current(true, "_Top");

            // Added 3/29/2020 thomas downes
            strFullPathToJsonFile_Width =  ciBadgeForWeb.App_Start.DiskFiles.PathToFile_JSON_Current(true, "_Width");
            strFullPathToJsonFile_Height = ciBadgeForWeb.App_Start.DiskFiles.PathToFile_JSON_Current(true, "_Height");

            // Added 3/21/2020 td
            if (Directory.Exists(strFullPathToJsonFile_Left))
            {
                if (false == File.Exists(strFullPathToJsonFile_Left))
                {
                    // Added 3/21/2020 td
                    throw new System.IO.FileNotFoundException("OOps... This is a folder, not a file.");
                }
            }

            // Added 3/29/2020 td
            if (Directory.Exists(strFullPathToJsonFile_Width))
            {
                if (false == File.Exists(strFullPathToJsonFile_Width))
                {
                    // Added 3/29/2020 td
                    throw new System.IO.FileNotFoundException("OOps... This is a folder, not a file.");
                }
            }

            //3-24-2020 td//this.FullPathToFile = strFullPathToJsonFile;
            this.FullPathToFile_Left = strFullPathToJsonFile_Left;
            this.FullPathToFile_Top = strFullPathToJsonFile_Top;

            //Added 3/29/2020 thomas downes
            this.FullPathToFile_Width = strFullPathToJsonFile_Width;
            this.FullPathToFile_Height = strFullPathToJsonFile_Height;

            // 3-24-2020 td//this.JsonTextContent = File.ReadAllText(strFullPathToJsonFile);
            this.JsonTextContent_Left = File.ReadAllText(strFullPathToJsonFile_Left);
            this.JsonTextContent_Top = File.ReadAllText(strFullPathToJsonFile_Top);

            //Added 3/29/2020 thomas downes
            this.JsonTextContent_Width = File.ReadAllText(strFullPathToJsonFile_Width);
            this.JsonTextContent_Height = File.ReadAllText(strFullPathToJsonFile_Height);

            if (false)
            {  
            }

        }

        public void Save()
        {
            //
            // Added 3/21/2020 Thomas Downes
            //
            // 3-24-2020 td // File.WriteAllText(this.FullPathToFile, this.JsonTextContent);
            File.WriteAllText(this.FullPathToFile_Left, this.JsonTextContent_Left);
            File.WriteAllText(this.FullPathToFile_Top, this.JsonTextContent_Top);

            // Added 3/29/2020 Thomas Downes
            File.WriteAllText(this.FullPathToFile_Width, this.JsonTextContent_Width);
            File.WriteAllText(this.FullPathToFile_Height, this.JsonTextContent_Height);

        }




    }
}