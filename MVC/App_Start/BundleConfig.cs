using System.Web;
using System.Web.Optimization;

namespace MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Additional/CSS").Include(
               "~/AdditionalCSSJS/bower_components/bootstrap/dist/css/bootstrap.min.css",
               "~/AdditionalCSSJS/bower_components/font-awesome/css/font-awesome.min.css",
               "~/AdditionalCSSJS/bower_components/Ionicons/css/ionicons.min.css",
               "~/AdditionalCSSJS/dist/css/AdminLTE.min.css",
               "~/AdditionalCSSJS/dist/css/skins/_all-skins.min.css",
               "~/AdditionalCSSJS/bower_components/morris.js/morris.css",
               "~/AdditionalCSSJS/bower_components/jvectormap/jquery-jvectormap.css",
               "~/AdditionalCSSJS/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
               "~/AdditionalCSSJS/bower_components/bootstrap-daterangepicker/daterangepicker.css",
               "~/AdditionalCSSJS/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
               "~/Content/alertifyjs/alertify.min.css",
               "~/Content/alertifyjs/themes/default.min.css"


               ));

            bundles.Add(new ScriptBundle("~/Additional/JS").Include(
            "~/AdditionalCSSJS/bower_components/jquery/dist/jquery.min.js",
            "~/AdditionalCSSJS/bower_components/jquery-ui/jquery-ui.min.js",
            "~/AdditionalCSSJS/bower_components/bootstrap/dist/js/bootstrap.min.js",
            "~/AdditionalCSSJS/bower_components/raphael/raphael.min.js",
            "~/AdditionalCSSJS/bower_components/morris.js/morris.min.js",
            "~/AdditionalCSSJS/bower_components/jquery-sparkline/dist/jquery.sparkline.min.js",
            "~/AdditionalCSSJS/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
            "~/AdditionalCSSJS/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
            "~/AdditionalCSSJS/bower_components/jquery-knob/dist/jquery.knob.min.js",
            "~/AdditionalCSSJS/bower_components/moment/min/moment.min.js",
            "~/AdditionalCSSJS/bower_components/bootstrap-daterangepicker/daterangepicker.js",
            "~/AdditionalCSSJS/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
            "~/AdditionalCSSJS/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
            "~/AdditionalCSSJS/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
            "~/AdditionalCSSJS/bower_components/fastclick/lib/fastclick.js",
            "~/AdditionalCSSJS/dist/js/adminlte.min.js",
            "~/AdditionalCSSJS/dist/js/pages/dashboard.js",
            "~/AdditionalCSSJS/dist/js/demo.js",
            "~/AdditionalCSSJS/alertify.min.js"

            ));
        }
    }
}
