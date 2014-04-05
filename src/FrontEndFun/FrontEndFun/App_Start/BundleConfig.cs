using System.Web;
using System.Web.Optimization;
using BundleTransformer.Core.Transformers;

namespace FrontEndFun {
    public class BundleConfig {

        private static void RegisterScssBundle(BundleCollection bundles) {

            var scssBundle = new StyleBundle("~/bundles/styles")
                .Include("~/Content/Styles/styles.scss");
            scssBundle.Transforms.Add(new CssTransformer());
            bundles.Add(scssBundle);
        }

        private static void RegisterCoffeeBundle(BundleCollection bundles) {
            var bundle = new ScriptBundle("~/bundles/coffee")
                .Include("~/Scripts/examples.coffee");
            bundle.Transforms.Add(new JsTransformer());
            bundles.Add(bundle);
        }

        public static void RegisterBundles(BundleCollection bundles) {

            RegisterScssBundle(bundles);
            RegisterCoffeeBundle(bundles);

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}