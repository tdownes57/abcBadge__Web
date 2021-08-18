using System.Web;
using System.Web.Optimization;

namespace ciBadgeForWeb
{
    public class BundleConfig
    {
        //----public class BundleConfig
        //----{
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
        //----}


        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles_Deprecated(BundleCollection bundles)
        {
            //---bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //---            "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.4.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //----bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //----"~/Scripts/bootstrap.js"));
            //----
            //   Please see the following StackOverflow link https://bit.ly/3gdg6nT
            //   Title of StackOverflow article:  
            //        Update From Bootstrap 3.7 to 5.0.2 in .net mvc producing Error- System.NullReferenceException
            //    Look for the answer which starts, "We replaced the following" and gives the code in BundleConfig.cs
            //    for replacing "ScriptBundle" with simply the parent class "Bundle".
            //
            //    https://stackoverflow.com/questions/68251763/update-from-bootstrap-3-7-to-5-0-2-in-net-mvc-producing-error-system-nullrefer
            //
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css"));

            // Added 8/17/2021 thomas downes
            bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include(
                      "~/Content/bootstrap.css"));

            // Added 8/17/2021  per 
            //    https://stackoverflow.com/questions/45105931/bootstrap-not-working-with-asp-net-mvc-bundling
            //
            //bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include(
            //"~/Content/bootstrap.min.css",
            //"~/Content/bootstrap.css"));

        }
    }
}
