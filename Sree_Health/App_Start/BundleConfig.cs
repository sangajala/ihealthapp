using System.Web;
using System.Web.Optimization;

namespace Sree_Health
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Scripts

            bundles.Add(new ScriptBundle("~/plugins/dataTables").Include(
          "~/Content/global_assets/js/plugins/tables/datatables/datatables.min.js",
          "~/Content/global_assets/js/plugins/tables/datatables/extensions/jszip/jszip.min.js",
          "~/Content/global_assets/js/plugins/tables/datatables/extensions/pdfmake/pdfmake.min.js",
          "~/Content/global_assets/js/plugins/tables/datatables/extensions/pdfmake/vfs_fonts.min.js",
          "~/Content/global_assets/js/plugins/tables/datatables/extensions/buttons.min.js",
          "~/Content/global_assets/js/demo_pages/datatables_extension_buttons_html5.js",
          "~/Content/global_assets/js/plugins/forms/selects/select2.min.js",
          "~/Content/global_assets/js/demo_pages/datatables_advanced.js"));

            #endregion Scripts



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
                      "~/Content/assets/css/bootstrap.css",
                      "~/Content/assets/css/site.css"));
            #region Old bundle
            //==================        Java Scripts     ================
            bundles.Add(new ScriptBundle("~/bundles/jquerylogin").Include(
           "~/Content/global_assets/js/plugins/forms/validation/validate.min.js",
           "~/Content/global_assets/js/plugins/forms/styling/uniform.min.js",
           "~/Content/assets/js/app.js",
           "~/Content/global_assets/js/demo_pages/login_validation.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquerycore").Include(
                       "~/Content/global_assets/js/main/jquery.min.js",
                       "~/Content/global_assets/js/main/bootstrap.bundle.min.js",
                       "~/Content/global_assets/js/plugins/loaders/blockui.min.js",
                       "~/Content/global_assets/js/plugins/ui/ripple.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquerytheme").Include(
                       "~/Content/global_assets/js/plugins/ui/perfect_scrollbar.min.js",
                       "~/Content/assets/js/app.js",
                       "~/Content/global_assets/js/plugins/notifications/sweet_alert.min.js",
                        "~/Content/assets/js/custom.js",
                       "~/Content/global_assets/js/demo_pages/layout_fixed_sidebar_custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryinputform").Include(
                       "~/Content/global_assets/js/plugins/forms/selects/select2.min.js",
                       "~/Content/global_assets/js/plugins/forms/styling/uniform.min.js",
                       "~/Content/global_assets/js/demo_pages/form_layouts.js",
                       "~/Content/global_assets/js/plugins/forms/selects/bootstrap_multiselect.js",
                       "~/Content/global_assets/js/plugins/uploaders/fileinput/fileinput.min.js",
                       "~/Content/assets/js/app.js"));

            bundles.Add(new ScriptBundle("~/plugins/dataTables").Include(
           "~/Content/global_assets/js/plugins/tables/datatables/datatables.min.js",
           "~/Content/global_assets/js/plugins/tables/datatables/extensions/jszip/jszip.min.js",
           "~/Content/global_assets/js/plugins/tables/datatables/extensions/pdfmake/pdfmake.min.js",
           "~/Content/global_assets/js/plugins/tables/datatables/extensions/pdfmake/vfs_fonts.min.js",
           "~/Content/global_assets/js/plugins/tables/datatables/extensions/buttons.min.js",
           "~/Content/global_assets/js/demo_pages/datatables_extension_buttons_html5.js",
           "~/Content/global_assets/js/plugins/forms/selects/select2.min.js",
           "~/Content/global_assets/js/demo_pages/datatables_advanced.js"));

            bundles.Add(new ScriptBundle("~/bundles/sweetalert").Include(
                     "~/Content/global_assets/js/plugins/notifications/sweet_alert.min.js"));

            /*
    <script src="../Content/global_assets/js/plugins/uploaders/fileinput/fileinput.min.js"></script>
             */

            //==================        CSS     ================
            bundles.Add(new StyleBundle("~/Content/Mycss").Include(
            "~/Content/global_assets/css/icons/icomoon/styles.min.css", new CssRewriteUrlTransform()).Include(
            "~/Content/assets/css/bootstrap.min.css",
            "~/Content/assets/css/bootstrap_limitless.min.css",
            "~/Content/assets/css/layout.min.css",
            "~/Content/assets/css/components.min.css",
            "~/Content/assets/css/colors.min.css",
            "~/Content/assets/css/MyCustomStyle.css"
            ));
            bundles.Add(new StyleBundle("~/Content/sweetalert").Include(
                "~/Content/css/plugins/sweetalert/sweetalert.css"));
            /*
             */

            //==================             ================
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(    // for screen response & identification of screen view
                        "~/Scripts/modernizr-*"));
            //==================             ================















            bundles.Add(new ScriptBundle("~/bundles/jqueryflot").Include(
                       "~/Content/js/plugins/flot/jquery.flot.js",
                       "~/Content/js/demo/peity-demo.js"));


            bundles.Add(new ScriptBundle("~/bundles/jquerypeity").Include(
                     "~/Content/js/plugins/peity/jquery.peity.min.js",
                     "~/Content/js/plugins/flot/jquery.flot.tooltip.min.js",
                     "~/Content/js/plugins/flot/jquery.flot.spline.js",
                     "~/Content/js/plugins/flot/jquery.flot.resize.js",
                     "~/ Content/js/plugins/flot/jquery.flot.pie.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquerygritter").Include(
                    "~/Content/js/plugins/gritter/jquery.gritter.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquerysparkline").Include(
                    "~/Content/js/demo/sparkline-demo.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquerychart").Include(
                   "~/Content/js/plugins/chartJs/Chart.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquerytoastr").Include(
                   "~/Content/js/plugins/toastr/toastr.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryplugin").Include(
                        "~/Content/js/inspinia.js",
                        "~/Content/js/plugins/pace/pace.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Content/js/plugins/jquery-ui/jquery-ui.min.js"));
            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/summernote").Include(
                     "~/Content/js/plugins/summernote/summernote.min.js"));

            // summernote 


            // Select2
            bundles.Add(new ScriptBundle("~/bundles/select2").Include(
                      "~/Content/js/plugins/select2/select2.full.min.js"));

            bundles.Add(new StyleBundle("~/Content/plugins/dataTables/dataTablesStyles").Include(
                "~/Content/css/plugins/dataTables/datatables.min.css"));

            // dataTables 
            bundles.Add(new ScriptBundle("~/plugins/dataTables").Include(
                       "~/Content/global_assets/js/plugins/tables/datatables/datatables.min.js",
                       "~/Content/global_assets/js/plugins/tables/datatables/extensions/jszip/jszip.min.js",
                       "~/Content/global_assets/js/plugins/tables/datatables/extensions/pdfmake/pdfmake.min.js",
                       "~/Content/global_assets/js/plugins/tables/datatables/extensions/pdfmake/vfs_fonts.min.js",
                       "~/Content/global_assets/js/plugins/tables/datatables/extensions/buttons.min.js",
                       "~/Content/global_assets/js/demo_pages/datatables_extension_buttons_html5.js"));

            bundles.Add(new ScriptBundle("~/plugins/daterangepicker").Include(
                      "~/Content/js/plugins/daterangepicker/daterangepicker.js"));

            // dataTables 


            // dataTables 


            // Datepicker style



            //bundles.Add(new StyleBundle("~/Content/Mycss").Include(
            //            "~/Content/global_assets/css/icons/icomoon/styles.min.css", new CssRewriteUrlTransform()).Include(
            //            "~/Content/assets/css/bootstrap.min.css",
            //            "~/Content/assets/css/bootstrap_limitless.min.css",
            //            "~/Content/assets/css/layout.min.css",
            //            "~/Content/assets/css/components.min.css",
            //            "~/Content/assets/css/colors.min.css",
            //            "~/Content/assets/css/custom.css"));

            bundles.Add(new StyleBundle("~/bundles/summernoteStyles").Include(
                   "~/Content/css/plugins/summernote/summernote.css").Include(
                "~/Content/css/plugins/summernote/summernote-bs3.css", new CssRewriteUrlTransform()));


            bundles.Add(new StyleBundle("~/bundles/select2Styles").Include(
                  "~/Content/css/plugins/select2/select2.min.css"));
            bundles.Add(new StyleBundle("~/bundles/sweetalert").Include(
                "~/Content/css/plugins/sweetalert/sweetalert.css"));
            bundles.Add(new StyleBundle("~/bundles/daterangepicker").Include(
                  "~/Content/css/plugins/daterangepicker/daterangepicker-bs3.css"));

            #endregion Old bundle
        }
    }
}
