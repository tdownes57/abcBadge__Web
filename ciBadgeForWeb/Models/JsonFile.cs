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
        private string mod_JsonTextContent = "{\"Element4_top\":\"352px\",\"Element4_left\":\"532px\",\"Element3_top\":\"352px\",\"Element3_left\":\"314px\",\"Element6_top\":\"351px\",\"Element6_left\":\"91px\",\"Element5_top\":\"496px\",\"Element5_left\":\"87px\",\"Element2_top\":\"499px\",\"Element2_left\":\"313px\",\"Element1_top\":\"499px\",\"Element1_left\":\"535px\",\"Element9_top\":\"400px\",\"Element9_left\":\"88px\",\"Element8_top\":\"448px\",\"Element8_left\":\"87px\",\"Element10_top\":\"403px\",\"Element10_left\":\"314px\",\"Element11_top\":\"451px\",\"Element11_left\":\"314px\",\"Element12_top\":\"404px\",\"Element12_left\":\"533px\",\"Element7_top\":\"454px\",\"Element7_left\":\"535px\"}";

        public string JsonTextContent {
            get
            {
                //Added 3/21/2020 thomas downes
                return mod_JsonTextContent;
            }
            set
            {
                //Added 3/21/2020 thomas downes
                mod_JsonTextContent = value;
            }
        }

        public string FullPathToFile { get; set; }

        public string NameOfClassType { get; set;  }

        public JsonFile()
        {
            //
            // Added 3/21/2020 Thomas Downes  
            //
            string strFullPathToJsonFile;

            // Get the JSON file.  
            strFullPathToJsonFile = ciBadgeForWeb.App_Start.DiskFiles.PathToFile_JSON_Current(true);
            
            // Added 3/21/2020 td
            if (Directory.Exists(strFullPathToJsonFile))
            {
                if (false == File.Exists(strFullPathToJsonFile))
                {
                    // Added 3/21/2020 td
                    throw new System.IO.FileNotFoundException("OOps... This is a folder, not a file.");
                }
            }

            this.FullPathToFile = strFullPathToJsonFile;
            this.JsonTextContent = File.ReadAllText(strFullPathToJsonFile);

            if (false)
            {  
            }

        }

        public void Save()
        {
            //
            // Added 3/21/2020 Thomas Downes
            //
            File.WriteAllText(this.FullPathToFile, this.JsonTextContent);

        }




    }
}