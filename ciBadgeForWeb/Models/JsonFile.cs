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

        public string JsonTextContent { get; set; }


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

            this.FullPathToFile = strFullPathToJsonFile;
            this.JsonTextContent = File.ReadAllText(strFullPathToJsonFile);


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