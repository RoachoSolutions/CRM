using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RoachoSLN.Web.MVC.Attributes
{
    public class InternationalizationAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            string language = "";
            string culture = "";
            language = (string)filterContext.RouteData.Values["language"] ?? language;
            culture = (string)filterContext.RouteData.Values["culture"] ?? culture;

            language = (string)filterContext.HttpContext.Session["language"] ?? language;
            culture = (string)filterContext.HttpContext.Session["culture"] ?? culture;

            if (language != "" && culture != "")
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(string.Format("{0}-{1}", language, culture));
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(string.Format("{0}-{1}", language, culture));
            }
            else
            {
                if (language != "")
                {
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(string.Format("{0}", language));
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(string.Format("{0}", language));                    
                }
                else
                {
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("es-MX");
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es-MX");
                }             
            }

        }
    }
}
