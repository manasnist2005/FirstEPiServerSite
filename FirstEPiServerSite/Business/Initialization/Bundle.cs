using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace FirstEPiServerSite.Business.Initialization
{
    [InitializableModule]
    public class BundleConfig : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (context.HostType == HostType.WebApplication)
            {
                RegisterBundles(BundleTable.Bundles);
            }
        }

        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Static/js/jquery.js", //jquery.js can be removed and linked from CDN instead, we use a local one for demo purposes without internet connectionzz
                        "~/Static/js/bootstrap.js", "~/Static/js/bootstrap-collapse"));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Static/css/bootstrap.min.css", new CssRewriteUrlTransform())
                .Include("~/Static/css/bootstrap-responsive.min.css")
                .Include("~/Static/css/bootstrap-theme.css")
                .Include("~/Static/css/main.css")
                .Include("~/Static/css/app.css")
                .Include("~/Static/css/media.css")
                .Include("~/Static/css/style.css", new CssRewriteUrlTransform())
                .Include("~/Static/css/editmode.css"));
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}