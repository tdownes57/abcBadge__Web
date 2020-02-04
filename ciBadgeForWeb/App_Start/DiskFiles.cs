using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;  //Added 11/28/2019 td
using System.Web.Hosting; //Added 11/25/2019 td  

namespace ciBadgeForWeb.App_Start
{
    public class DiskFiles
    {
        //
        //Added 11/15/2019 td  
        //
        private static string mod_fileTitleXML_Current = ""; //Added 11/28/2019 td 

        public static string PathToFile_BackImage(string pstrFileTitle, bool pboolAbsolute)
        {
            //
            //Added 1/14/2020
            //
            //bool boolNotYetDetermined = ("" == mod_fileTitleXML_Current);
            string strPathToFileJpeg = "";
            string strPathToFolderBackJpegs = DiskFolders.PathToFolderWithBacks(pboolAbsolute);
            bool boolMatchOfTitle = false;

            foreach (FileInfo file_Info in (new DirectoryInfo(strPathToFolderBackJpegs)).GetFiles(pstrFileTitle))
            {
                boolMatchOfTitle = (file_Info.Name.ToUpper() == pstrFileTitle.ToUpper());
                
                if (boolMatchOfTitle)
                {
                    strPathToFileJpeg = file_Info.FullName;
                    break;
                }
            }
            
            //strPathToFileJpeg = Path.Combine(strPathToFolderBackJpegs, );
            return strPathToFileJpeg;
        }

        public static void SpecifyCurrent_XML(string xmlDesiredCacheFile)
        {
            //Added 11/29/2019 td 
            mod_fileTitleXML_Current = xmlDesiredCacheFile;
        }

        public static string PathToFile_XML_Current(bool pboolAbsolute)
        {
            //
            //Added 11/28/2192
            //
            //return PathToFile_XML(pboolAbsolute);

            bool boolNotYetDetermined = ("" == mod_fileTitleXML_Current);
            string strPathToFileXML = "";
            string strPathToFolderXML = DiskFolders.PathToFolder_XML(pboolAbsolute);

            if (boolNotYetDetermined)
            {
                foreach (FileInfo file_Info in (new DirectoryInfo(strPathToFolderXML)).GetFiles("*.xml"))
                {
                    if (boolNotYetDetermined)
                    {
                        mod_fileTitleXML_Current = file_Info.Name;
                        break;
                    }
                }
            }
            strPathToFileXML = Path.Combine(strPathToFolderXML, mod_fileTitleXML_Current);
            return strPathToFileXML;
        }

        public static string PathToFile_XML_Next(bool pboolAbsolute)
        {
            //
            //Added 11/28/2192
            //
            bool boolNotYetDetermined = ("" == mod_fileTitleXML_Current);
            string strPathToFileXML = "";
            string strPathToFolderXML = DiskFolders.PathToFolder_XML(pboolAbsolute);
            bool boolMatchesCurrent = false;
            bool boolGrabThisNextFile = false;
            FileInfo obj_nextFileInfo = null;
            bool boolTrySecondAttempt = false;
            bool boolStartFromBeginningAgain = false; 

            if (boolNotYetDetermined)
            {
                mod_fileTitleXML_Current = PathToFile_XML_Current(pboolAbsolute);
            }

            while (true)
            {
                foreach (FileInfo each_file_Info in (new DirectoryInfo(strPathToFolderXML)).GetFiles("*.xml"))
                {
                    if (boolGrabThisNextFile)
                    {
                        obj_nextFileInfo = each_file_Info;
                        break;
                    }
                    boolMatchesCurrent = (each_file_Info.Name == mod_fileTitleXML_Current);
                    if (boolMatchesCurrent)
                    {
                        //mod_fileTitleXML_Current = each_file_Info.Name;
                        //break;
                        //-----Prepare for the next interation. 
                        boolGrabThisNextFile = true;
                    }
                    //If we've come full circle, grab the first XML file.
                    if (boolStartFromBeginningAgain)
                    {
                        //We've come full circle, so grab the first XML file.
                        obj_nextFileInfo = each_file_Info;
                        break;
                    }
                }
                if (obj_nextFileInfo != null) break; // = true;
                //Let's avoid infinite loops!!
                if (obj_nextFileInfo == null && boolTrySecondAttempt) break; // = true;
                if (obj_nextFileInfo == null) boolTrySecondAttempt = true;
                //Take the very first file. ---11/29/2019 td
                if (obj_nextFileInfo == null) boolStartFromBeginningAgain = true;
            }

            if (obj_nextFileInfo == null) throw new Exception("We are unable to locate any additional XML files.");
            if (obj_nextFileInfo != null) mod_fileTitleXML_Current = obj_nextFileInfo.Name;
            strPathToFileXML = Path.Combine(strPathToFolderXML, mod_fileTitleXML_Current);
            return strPathToFileXML;
        }

        public static string PathToFile_XML_NotInUse(bool pboolAbsolute )
        {
            //Return My.Application.Info.DirectoryPath & "\Images\Signatures\Declaration_bmp.bmp"

            //return "";
            //return "~/XML/ciLayoutDesignVB.xml";

            string strPathToFile_Virtual = "/XML/ciLayoutDesignVB_new.xml";
            string strPathToFile_Absolute = HostingEnvironment.MapPath(strPathToFile_Virtual);

            if (pboolAbsolute) return strPathToFile_Absolute;
            return strPathToFile_Virtual;

        }

        public static string PathToFile_Sig(bool pboolAbsolute)
        {
            //Return My.Application.Info.DirectoryPath & "\Images\Signatures\Declaration_bmp.bmp"

            //return System.IO.Path.Combine("C:\\Users\\tdown\\source",
            //    "repos\\ciLayout\\ciLayoutDesignVB\\bin\\Debug",
            //    "Images\\Signatures\\Declaration_bmp.bmp");

            // 11/26/2019 td//return "~/Images/Signatures/Declaration_bmp.bmp";

            string strPathToFile_Virtual = "~/Images/Signatures/Declaration_bmp.bmp";
            string strPathToFile_Absolute = HostingEnvironment.MapPath(strPathToFile_Virtual);

            if (pboolAbsolute) return strPathToFile_Absolute;
            return strPathToFile_Virtual;

        }

        public static string PathToFile_QRCode(bool pboolAbsolute)
        {
            //Return My.Application.Info.DirectoryPath & "\Images\Signatures\Declaration_bmp.bmp"

            //return System.IO.Path.Combine("C:\\Users\\tdown\\source",
            //    "repos\\ciLayout\\ciLayoutDesignVB\\bin\\Debug",
            //    "Images\\QRCodes\\ExampleQR.png");

            //return "~/Images/QRCodes/ExampleQR.png";

            string strPathToFile_Virtual = "~/Images/QRCodes/ExampleQR.png";
            string strPathToFile_Absolute = HostingEnvironment.MapPath(strPathToFile_Virtual);

            if (pboolAbsolute) return strPathToFile_Absolute;
            return strPathToFile_Virtual;

        }



    }
}