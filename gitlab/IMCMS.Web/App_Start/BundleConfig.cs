using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace IMCMS.Web.App_Start
{
  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      //bundles.Add(new ScriptBundle("~/bundles/js/modernizer").Include("~/includes/js/modernizr.js"));
      bundles.Add(new ScriptBundle("~/bundles/js/jquery").Include("~/includes/js/jquery.js"));
      bundles.Add(new ScriptBundle("~/bundles/js/jquery-ui").Include("~/includes/js/jquery-ui.js"));
      bundles.Add(new ScriptBundle("~/bundles/js/eui").IncludeDirectory("~/includes/js/common", "*.js").IncludeDirectory("~/includes/js/eui", "*.js"));
      bundles.Add(new ScriptBundle("~/bundles/js/aui").IncludeDirectory("~/includes/js/common", "*.js").IncludeDirectory("~/includes/js/aui", "*.js"));
      bundles.Add(new ScriptBundle("~/bundles/js/imageuploader").IncludeDirectory("~/includes/js/imageuploader", "*.js"));
      bundles.Add(new ScriptBundle("~/bundles/js/encrypt").IncludeDirectory("~/includes/js/encrypt", "*.js"));
      bundles.Add(new ScriptBundle("~/bundles/js/adminnav").Include("~/includes/js/admin-nav.js"));

      bundles.Add(new StyleBundle("~/bundles/css/eui").Include("~/includes/css/fonts.css", "~/includes/css/font-awesome.css", "~/includes/css/site.css", "~/includes/css/responsive.css"));
      bundles.Add(new StyleBundle("~/bundles/css/adminnav").Include("~/includes/css/admin-nav.css"));
      bundles.Add(new StyleBundle("~/bundles/css/aui").Include(
          "~/includes/css/font-awesome.css", // this should come first always. unless you know what you're doing and suffer the wrath.
          "~/includes/css/admin-nav.css",
          "~/includes/css/admin.css"));
      bundles.Add(new StyleBundle("~/bundles/css/jquery-ui").Include("~/includes/css/jquery-ui/jquery-ui.css", new CssRewriteUrlTransform()));
      /*bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
          "~/Scripts/Lib/jquery/jquery-{version}.js",
          "~/Scripts/Lib/jquery/jquery.*",
          "~/Scripts/Lib/jquery/jquery-ui-{version}.js")
      );
      bundles.Add(new ScriptBundle("~/Scripts/knockout").Include(
           "~/Scripts/Lib/knockout/knockout-{version}.js",
           "~/Scripts/Lib/knockout/knockout-deferred-updates.js")
      );*/
    }
  }
}