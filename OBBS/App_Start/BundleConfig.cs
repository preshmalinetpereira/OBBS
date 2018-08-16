using System.Web;
using System.Web.Optimization;

namespace OBBS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.2.1.min.js",
                        "~/Scripts/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/popper.js"));

            bundles.Add(new ScriptBundle("~/bundles/customjs").Include(
                      "~/Scripts/categories_custom.js",
                      "~/Scripts/contact_custom.js",
                      "~/Scripts/custom.js",
                      "~/Scripts/single_custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/pluginjs").Include(
                      "~/Content/plugins/Isotope/isotope.pkgd.min.js",
                      "~/Content/plugins/OwlCarousel2-2.2.1/owl.carousel.js",
                      "~/Scripts/custom.js",
                      "~/Content/plugins/easing/easing.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                       "~/Content/jquery-ui.css"));

            bundles.Add(new StyleBundle("~/Content/categoriescss").Include(
                      "~/Content/categories_responsive.css",
                      "~/Content/categories_styles.css"));

            bundles.Add(new StyleBundle("~/Content/contactcss").Include(
                     "~/Content/contact_responsive.css",
                     "~/Content/contact_styles.css"));

            bundles.Add(new StyleBundle("~/Content/customcss").Include(
                     "~/Content/main_styles.css",
                     "~/Content/responsive.css"));

            bundles.Add(new StyleBundle("~/Content/singlecss").Include(
                      "~/Content/single_responsive.css",
                      "~/Content/single_styles.css"));

            bundles.Add(new StyleBundle("~/Content/owlcss").Include(
                      "~/Content/plugins/OwlCarousel2-2.2.1/owl.carousel.css",
                      "~/Content/plugins/OwlCarousel2-2.2.1/owl.theme.default.css"));

            bundles.Add(new StyleBundle("~/Content/plugincss").Include(
                      "~/Content/plugins/OwlCarousel2-2.2.1/animate.css",
                      "~/Content/plugins/font-awesome-4.7.0/css/font-awesome.min.css"));


        }
    }
}
