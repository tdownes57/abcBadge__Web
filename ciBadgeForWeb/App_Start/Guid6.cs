using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ciBadgeForWeb.App_Start
{
    //
    //   The class "Guid6" (in "par_guid6Config") means a random-generated 6-character Guid.
    //    ----11/4/2021 TD
    //
    public class Guid6
    {
        //
        //   The class "Guid6" (in "par_guid6Config") means a random-generated 6-character Guid.
        //    This class will help bigly with differentiating various customer's badges (and 
        //    a customer's >=1 Personality Configurations).
        //    ----11/4/2021 TD
        //
        public string GetNewGuid6()
        {
            //
            //   The class "Guid6" (in "par_guid6Config") means a random-generated 6-character Guid.
            //    ----11/4/2021 TD
            //
            //   https://docs.microsoft.com/en-us/dotnet/api/system.guid?view=net-5.0
            //   [Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4")] 
            //   [Guid("936DA01F-9ABD-4d9d-80C7-02AF85C822A8")]
            //          01234567890123456789012345
            //
            //   "F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4".Substring(25, 6) = "29BF39"
            //   "936DA01F-9ABD-4d9d-80C7-02AF85C822A8".Substring(25, 6) = "2AF85C"
            //
            //---return System.Guid.NewGuid().ToString().Substring(3, 6);
            //--==return System.Guid.NewGuid().ToString().Substring(25, 6);
            //--==return System.Guid.NewGuid().ToString().Substring(33, 6);
            return System.Guid.NewGuid().ToString().Substring(25, 6);

        }


    }
}