using RoachoSLN.Web.MVC.Helpers;
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
        public ActionResult AgregarNota(string id, string nota)
        {
            RoachoSLN.Entidades.Resultados.ResultadoJson _retvalue = new RoachoSLN.Entidades.Resultados.ResultadoJson();
            RoachoSLN.Entidades.CRM.ProspectoNota _nota = new RoachoSLN.Entidades.CRM.ProspectoNota();

            Guid _id;
            if (Guid.TryParse(id, out _id))
            {
                RoachoSLN.BOL.CRM.Prospectos.AgregarNota(nota, _id, Guid.Empty, out _nota);
                _retvalue.result = PartialView("_elementosnota", _nota).RenderToString();
                _retvalue.status = 1;

            }
            else
            {
                _retvalue.error = "Prospecto no valido";
                _retvalue.status = 2;
            }

            return Json(_retvalue);
        }

        [HttpGet]
        public ActionResult ObtenerNotas(string id, string idnota)
        {
            RoachoSLN.Entidades.Resultados.ResultadoJson _retvalue = new RoachoSLN.Entidades.Resultados.ResultadoJson();
            string view = "";
            Guid _id;
            int _idnota;
            if (Guid.TryParse(id, out _id) && int.TryParse(idnota, out _idnota))
            {
                List<RoachoSLN.Entidades.CRM.ProspectoNota> _notas = RoachoSLN.BOL.CRM.Prospectos.ObtenerNotas(_id, _idnota);
                foreach(RoachoSLN.Entidades.CRM.ProspectoNota _nota in _notas)
                    view += PartialView("_elementosnota", _nota).RenderToString();
                _retvalue.result = view;
                if (_notas.Count == 5)
                    _retvalue.id = _notas.Min(x => x.id).ToString();
                else
                    _retvalue.id = "-1";
                _retvalue.status = 1;
            }
            else
            {
                _retvalue.error = "Prospecto no valido";
                _retvalue.status = 2;
            }
            return Json(_retvalue, JsonRequestBehavior.AllowGet);
        }
    }
}