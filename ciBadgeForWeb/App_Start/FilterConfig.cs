using System.Web;
using System.Web.Mvc;

namespace ciBadgeForWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)   
        {

            //            You can apply filters at global level in the Application_Start event of Global.asax.cs file by 
            //            using default FilterConfig.RegisterGlobalFilters() mehtod.Global filters will be applied to all the controller 
            //            and action methods of an application. 
            //         The[HandleError] filter is applied globaly in MVC Application by default in every MVC application created 
            //         using Visual Studio as shown below.
            //        --- https://www.tutorialsteacher.com/mvc/filters-in-asp.net-mvc
            //
            //

           filters.Add(new HandleErrorAttribute());
        }
    }
}
