using System.Web;
using System.Web.Optimization;

namespace RCM_V2
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js",
                       "~/Vendor/DataTables/DataTables-1.10.21/js/jquery.dataTables.min.js",
                       "~/Vendor/DataTables/DataTables-1.10.21/js/dataTables.bootstrap4.min.js",
                      "~/Scripts/moment.js",
                      "~/Scripts/bootstrap-datetimepicker.min.js",                       
                      "~/Scripts/Common.js",
                      "~/Scripts/SweetAlert2.js",
                      "~/Scripts/cleave.min.js"
                      ));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //            "~/Content/bootstrap.css",
            //          "~/Vendor/DataTables/DataTables-1.10.21/css/dataTables.bootstrap4.min.css",
            //          "~/Content/bootstrap-datetimepicker.min.css",                 
            //          //"~/Content/site.css",
            //           "~/Content/base.css",
            //          "~/Content/common.css",
            //          "~/Content/common1.css",
            //           "~/Content/manager-style.css"
            //           ));
        }
    }
}
