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
                      "~/Scripts/Common.js"
                      //"~/Vendor/DataTables/DataTables-1.10.21/js/juery.dataTables.min.js",
                      //"~/Vendor/DataTables/DataTables-1.10.21/js/dataTables.bootstrap.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/fontawesome/css/font-awesome.min.css",
                      "~/Content/site.css",
                       "~/Content/base.css",
                      "~/Content/common.css",
                      "~/Content/common1.css",
                       "~/Content/manager-style.css"
                       //"~/Vendor/DataTables/DataTables-1.10.21/css/juery.dataTables.min.css",
                       //"~/Vendor/DataTables/DataTables-1.10.21/js/dataTables.bootstrap.min.css"                    
                       ));
        }
    }
}
