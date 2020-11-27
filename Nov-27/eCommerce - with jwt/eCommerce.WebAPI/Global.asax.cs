using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace eCommerce.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Executes on receiving first request after deployment into production server
        /// </summary>
        protected void Application_Start()
        {
            UnityConfig.RegisterComponents(); //add this line
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
