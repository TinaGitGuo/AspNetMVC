using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AspNetMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            //定义名为"mycss"的捆绑,js对应为 new JsMinify() 
            //var b = new Bundle("~/mycss", new CssMinify());
            ////添加Content文件夹下的所有css文件到捆绑 
            ////第三个参数false表示，Content文件夹下的子文件夹下不添加到捆绑 
            //b.AddDirectory("~/Content", "*.css", false);
            ////添加到BundleTable 
            //BundleTable.Bundles.Add(b);

        }
        protected void Application_BeginRequest()
        {
            //RegExRewriteRule rule = new RegExRewriteRule();
            //rule.VirtualUrl = "~/test";
            //rule.DestinationUrl = "/";
            //rule.IgnoreCase = true;
            //rule.Redirect = RedirectOption.Application;
            //rule.RewriteUrlParameter = RewriteUrlParameterOption.ExcludeFromClientQueryString;

            //UrlRewriting.AddRewriteRule("ruleTest", rule);
        }
    }
}
