using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciBadgeForWeb.App_Start
{
    public class DiskFiles
    {
        //
        //Added 11/15/2019 td  
        //
        public static string PathToFile_XML()
        {
            //Return My.Application.Info.DirectoryPath & "\Images\Signatures\Declaration_bmp.bmp"

            return ""; 

        }

        public static string PathToFile_Sig()
        {
            //Return My.Application.Info.DirectoryPath & "\Images\Signatures\Declaration_bmp.bmp"

            return System.IO.Path.Combine("C:\\Users\\tdown\\source",
                "repos\\ciLayout\\ciLayoutDesignVB\\bin\\Debug",
                "Images\\Signatures\\Declaration_bmp.bmp");

        }

        public static string PathToFile_QRCode()
        {
            //Return My.Application.Info.DirectoryPath & "\Images\Signatures\Declaration_bmp.bmp"

            return System.IO.Path.Combine("C:\\Users\\tdown\\source",
                "repos\\ciLayout\\ciLayoutDesignVB\\bin\\Debug",
                "Images\\QRCodes\\ExampleQR.png");

        }

    }
}