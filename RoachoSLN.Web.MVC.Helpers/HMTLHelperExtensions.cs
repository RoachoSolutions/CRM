using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RoachoSLN.Web.MVC.Helpers
{
    public static class HMTLHelperExtensions
    {
        public static string IsSelected(this HtmlHelper html,string area=null, string controller = null, string action = null)
        {
            string cssClass = "active";
            string currentArea = (string)html.ViewContext.RouteData.DataTokens["area"];
            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            string currentController = (string)html.ViewContext.RouteData.Values["controller"];

            if (String.IsNullOrEmpty(area))
                area = currentArea;

            if (String.IsNullOrEmpty(controller))
                controller = currentController;

            if (String.IsNullOrEmpty(action))
                action = currentAction;

            return controller == currentController && action == currentAction && area==currentArea ?
                cssClass : String.Empty;
        }

        public static string PageClass(this HtmlHelper html)
        {
            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            return currentAction;
        }

    }
}
