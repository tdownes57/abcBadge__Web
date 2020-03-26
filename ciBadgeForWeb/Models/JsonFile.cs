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
        //private string mod_JsonTextContent = "{\"Element4_top\":\"352px\",\"Element4_width\":\"532px\",\"Element3_top\":\"352px\",\"Element3_left\":\"314px\",\"Element6_top\":\"351px\",\"Element6_left\":\"91px\",\"Element5_top\":\"496px\",\"Element5_left\":\"87px\",\"Element2_top\":\"499px\",\"Element2_left\":\"313px\",\"Element1_top\":\"499px\",\"Element1_left\":\"535px\",\"Element9_top\":\"400px\",\"Element9_left\":\"88px\",\"Element8_top\":\"448px\",\"Element8_left\":\"87px\",\"Element10_top\":\"403px\",\"Element10_left\":\"314px\",\"Element11_top\":\"451px\",\"Element11_left\":\"314px\",\"Element12_top\":\"404px\",\"Element12_left\":\"533px\",\"Element7_top\":\"454px\",\"Element7_left\":\"535px\"}";
        private string mod_JsonTextContent_Left = "{ \"Element4_left\":\"532px\", \"Element3_left\":\"314px\", \"Element6_left\":\"91px\", \"Element5_left\":\"87px\",  \"Element2_left\":\"313px\",  \"Element1_left\":\"499px\",  \"Element9_left\":\"88px\",  \"Element8_left\":\"87px\",  \"Element10_left\":\"314px\",  \"Element11_left\":\"314px\",  \"Element12_left\":\"533px\",  \"Element7_left\":\"535px\"  }";
        private string mod_JsonTextContent_Top = "{ \"Element4_top\":\"352px\",  \"Element3_top\":\"352px\",  \"Element6_top\":\"351px\",  \"Element5_top\":\"496px\",  \"Element2_top\":\"499px\",   \"Element1_top\":\"499px\",   \"Element9_top\":\"400px\",  \"Element8_top\":\"448px\",  \"Element10_top\":\"403px\",   \"Element11_top\":\"451px\",   \"Element12_top\":\"404px\",   \"Element7_top\":\"454px\"   }";

        //Added 3/26/2020 thomas downes
        private string mod_JsonTextContent_Width = "{ \"Element4_left\":\"532px\", \"Element3_left\":\"314px\", \"Element6_left\":\"91px\", \"Element5_left\":\"87px\",  \"Element2_left\":\"313px\",  \"Element1_left\":\"499px\",  \"Element9_left\":\"88px\",  \"Element8_left\":\"87px\",  \"Element10_left\":\"314px\",  \"Element11_left\":\"314px\",  \"Element12_left\":\"533px\",  \"Element7_left\":\"535px\"  }";
        private string mod_JsonTextContent_Height = "{ \"Element4_top\":\"352px\",  \"Element3_top\":\"352px\",  \"Element6_top\":\"351px\",  \"Element5_top\":\"496px\",  \"Element2_top\":\"499px\",   \"Element1_top\":\"499px\",   \"Element9_top\":\"400px\",  \"Element8_top\":\"448px\",  \"Element10_top\":\"403px\",   \"Element11_top\":\"451px\",   \"Element12_top\":\"404px\",   \"Element7_top\":\"454px\"   }";


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

        public string NameOfClassType { get; set;  }

        public JsonFile()
        {
            //
            // Added 3/21/2020 Thomas Downes  
            //
            // 3-24-2020 td//string strFullPathToJsonFile;
            string strFullPathToJsonFile_Left;
            string strFullPathToJsonFile_Top;

            // Get the JSON file.  
            // 3-24-2020 td//strFullPathToJsonFile = ciBadgeForWeb.App_Start.DiskFiles.PathToFile_JSON_Current(true);
            strFullPathToJsonFile_Left = ciBadgeForWeb.App_Start.DiskFiles.PathToFile_JSON_Current(true, "_Left");
            strFullPathToJsonFile_Top = ciBadgeForWeb.App_Start.DiskFiles.PathToFile_JSON_Current(true, "_Top");

            // Added 3/21/2020 td
            if (Directory.Exists(strFullPathToJsonFile_Left))
            {
                if (false == File.Exists(strFullPathToJsonFile_Left))
                {
                    // Added 3/21/2020 td
                    throw new System.IO.FileNotFoundException("OOps... This is a folder, not a file.");
                }
            }

            //3-24-2020 td//this.FullPathToFile = strFullPathToJsonFile;
            this.FullPathToFile_Left = strFullPathToJsonFile_Left;
            this.FullPathToFile_Top = strFullPathToJsonFile_Top;

            // 3-24-2020 td//this.JsonTextContent = File.ReadAllText(strFullPathToJsonFile);
            this.JsonTextContent_Left = File.ReadAllText(strFullPathToJsonFile_Left);
            this.JsonTextContent_Top = File.ReadAllText(strFullPathToJsonFile_Top);

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

        }




    }
}