using System.Web.Mvc;

namespace CRM.Areas.Prospectos
{
    public class ProspectosAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Prospectos";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {

            context.MapRoute(
                "Prospectos_view",
                "Prospectos/id/{id}",
                new {controller= "Detalle", action= "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Prospectos_default",
                "Prospectos/{controller}/{action}/{id}",
                new { controller = "Inicio", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}