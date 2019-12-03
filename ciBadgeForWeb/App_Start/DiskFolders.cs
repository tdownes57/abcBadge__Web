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
        //Added 11/15/2019 td  
        //
        public static string PathToFolder_XML(bool pboolAbsolute)
        {
            //
            //Added 11/28/2019 thomas downes 
            //
            string strPathToFolder_Virtual = "/XML";
            string strPathToFolder_Absolute = HostingEnvironment.MapPath(strPathToFolder_Virtual);

            if (pboolAbsolute) return strPathToFolder_Absolute;
            return strPathToFolder_Virtual;

        }

    }
}