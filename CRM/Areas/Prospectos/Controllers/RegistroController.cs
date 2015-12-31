using RoachoSLN.Entidades.Resultados;
using RoachoSLN.Web.MVC.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace CRM.Areas.Prospectos.Controllers
{
    [Internationalization]
    public class RegistroController : Controller
    {
        // GET: Prospectos/Registro
        public ActionResult Index()
        {
            ViewBag.Title = "Prospecto";
            return View(new RoachoSLN.Entidades.CRM.Prospectos() { id=Guid.Empty});
        }

        public ActionResult Editar(Guid id)
        {
            ViewBag.Title = "Prospecto";
            return View("Index", RoachoSLN.BOL.CRM.Prospectos.Obtener(id,true));
        }


        [HttpPost]
        public ActionResult Guardar(RoachoSLN.Entidades.CRM.Prospectos _pros)
        {
            ResultadoJson _retValue = new ResultadoJson();
            if (RoachoSLN.BOL.CRM.Prospectos.Guardar(_pros))
            {
                _retValue.id = _pros.id.ToString();
                _retValue.status = 1;                
            }
            else
            {
                _retValue.id = _pros.id.ToString();
                _retValue.status = 2;                
            }
            return Json(_retValue);
        }

    }
}