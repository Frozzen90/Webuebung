using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using WebUebung.Controllers;

namespace WebUebung
{
    public class Global : HttpApplication
    {
        private static Maincontroller _mCntr;

        public static Maincontroller MCntr { get => _mCntr; set => _mCntr = value; }

        void Application_Start(object sender, EventArgs e)
        {
            MCntr = new Maincontroller();
            MCntr.AddPers();
            // Code, der beim Anwendungsstart ausgeführt wird
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}