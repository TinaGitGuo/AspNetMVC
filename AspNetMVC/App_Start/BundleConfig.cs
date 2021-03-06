﻿using System.Web;
using System.Web.Optimization;

namespace AspNetMVC
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

            bundles.Add(new StyleBundle("~/mycss").Include(
                      "~/Content",
                      "~/Content/site.css"));


            ////定义名为"mycss"的捆绑,js对应为 new JsMinify() 
            //var b = new Bundle("~/mycss", new CssMinify());
            ////添加Content文件夹下的所有css文件到捆绑 
            ////第三个参数false表示，Content文件夹下的子文件夹下不添加到捆绑 
            ////b.AddDirectory("~/Content", "*.css", false);
            ////添加到BundleTable 
            //BundleTable.Bundles.Add(b);
        }
    }
}
