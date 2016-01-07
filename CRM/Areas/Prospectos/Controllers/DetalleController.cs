using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Areas.Prospectos.Controllers
{
    public class DetalleController : Controller
    {
        // GET: Prospectos/Detalle
        public ActionResult Index(string id)
        {
            ViewBag.Title = "Prospecto";
            Guid _id;
            RoachoSLN.Entidades.CRM.Prospectos _retvalue = new RoachoSLN.Entidades.CRM.Prospectos();

            if (!Guid.TryParse(id, out _id))
                return RedirectToAction("Index");

            if (Guid.Empty == _id)
                return RedirectToAction("Index");

            _retvalue = RoachoSLN.BOL.CRM.Prospectos.Obtener(_id, true);
            return View(_retvalue);
        }

        [HttpPost]
        public ActionResult AgregarNota(string id,string nota)
        {
            RoachoSLN.Entidades.Resultados.ResultadoJson _retvalue = new RoachoSLN.Entidades.Resultados.ResultadoJson();
            Guid _id;
            if (Guid.TryParse(id,out _id))
            {
                RoachoSLN.BOL.CRM.Prospectos.AgregarNota(nota, _id, Guid.Empty);
                _retvalue.status = 1;
            }
            else
            {                
                _retvalue.error = "Prospecto no valido";
                _retvalue.status = 2;
            }
            return Json(_retvalue);
        }
    }
}