using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RoachoSLN.Web.MVC.Helpers
{

    public static class ContentUrlHelper
    {
        public static string ContentArea(this UrlHelper url, string path)
        {
            var modulName = url.RequestContext.RouteData.DataTokens["area"];            
            string modulContentLoad = "";

            if (modulName != null)

            {
                if (!string.IsNullOrEmpty(modulName.ToString()))
                    modulContentLoad = "Areas/" + modulName;

                if (path.StartsWith("~/"))
                    path = path.Remove(0, 2);

                if (path.StartsWith("/"))
                    path = path.Remove(0, 1);


                path = path.Replace("../", string.Empty);

                return VirtualPathUtility.ToAbsolute("~/" + modulContentLoad + "/" + path);
            }

            return string.Empty;
        }

        //public static string BaseURL(this UrlHelper url)
        //{

        //}

        public static string CustomUrlArea(this UrlHelper url, string path,  bool controller = false)
        {
            var modulName = url.RequestContext.RouteData.DataTokens["area"];
            var controllerName = url.RequestContext.RouteData.Values["controller"];
            string modulContentLoad = "";


            if (modulName == null)
            {
                return string.Empty;
            }

            modulContentLoad = "/" + modulName;

            if (controller && controllerName!=null)
            {
                modulContentLoad += "/" + controllerName;
            }

            modulContentLoad += "/" + path;

            return modulContentLoad;
        }

    }
}

