using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting; //Added 11/25/2019 td  

namespace ciBadgeForWeb.App_Start
{
    public class DiskFiles
    {
        //
        //Added 11/15/2019 td  
        //
        public static string PathToFile_XML(bool pboolAbsolute )
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