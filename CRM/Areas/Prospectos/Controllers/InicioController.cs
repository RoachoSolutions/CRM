using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Areas.Prospectos.Controllers
{
    public class InicioController : Controller
    {
        // GET: Prospectos/Inicio
        public ActionResult Index()
        {
            ViewBag.Title = "Prospecto";
            List<RoachoSLN.Entidades.CRM.Prospectos> _prospectos = RoachoSLN.BOL.CRM.Prospectos.Lista();
            return View(_prospectos);
        }
    }
}