using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting; //Added 11/25/2019 td  

namespace ciBadgeForWeb.App_Start
{
    public class DiskFolders
    {
        //
        //Added 3/20/2020 td  
        //
        public static string PathToFolder_JSON(bool pboolAbsolute)
        {
            //
            //Added 3/20/2020 thomas downes 
            //
            string strPathToFolder_Virtual = "~/JSON";
            string strPathToFolder_Absolute = HostingEnvironment.MapPath(strPathToFolder_Virtual);

            if (pboolAbsolute) return strPathToFolder_Absolute;
            return strPathToFolder_Virtual;

        }

        //
        //Added 11/15/2019 td  
        //
        public static string PathToFolder_XML(bool pboolAbsolute)
        {
            //
            //Added 11/28/2019 thomas downes 
            //
            //string strPathToFolder_Virtual = "/XML";
            string strPathToFolder_Virtual = "~/XML";
            string strPathToFolder_Absolute = HostingEnvironment.MapPath(strPathToFolder_Virtual);

            if (pboolAbsolute) return strPathToFolder_Absolute;
            return strPathToFolder_Virtual;

        }

        public static string PathToFolderWithBacks(bool pboolAbsolute)
        {
            //
            //Added 12/11/2019 thomas downes 
            //
            //return (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");
            //string strPathToFolder_Virtual = "/Images/BackExamples";
            string strPathToFolder_Virtual = "~/Images/BackExamples";
            string strPathToFolder_Absolute = HostingEnvironment.MapPath(strPathToFolder_Virtual);

            if (pboolAbsolute) return strPathToFolder_Absolute;
            return strPathToFolder_Virtual;
        }


        public static string PathToFolderOfPics(bool pboolAbsolute)
        {
            //
            //Added 2/21/2020 thomas downes 
            //
            //return (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");
            string strPathToFolder_Virtual = "~/Images/PictureExamples";
            string strPathToFolder_Absolute = HostingEnvironment.MapPath(strPathToFolder_Virtual);

            if (pboolAbsolute) return strPathToFolder_Absolute;
            return strPathToFolder_Virtual;
        }


        public static System.IO.FileInfo PathToFolderOfPics_Example001()
        {
            //
            //Added 9/19/2020 thomas downes 
            //
            string strPathToFolder = PathToFolderOfPics(true);

            string strPathToPicture001 =  System.IO.Directory.GetFiles("001.jpg")[0];

            bool bExists = System.IO.File.Exists(strPathToPicture001);

            //if (bExists) return strPathToPicture001;
            if (bExists) return new System.IO.FileInfo(strPathToPicture001);
            return null; 

        }



    }
}