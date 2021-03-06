﻿using System;
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

        public ActionResult Detalle(string id)
        {
            ViewBag.Title = "Prospecto";
            Guid _id;
            RoachoSLN.Entidades.CRM.Prospectos _retvalue = new RoachoSLN.Entidades.CRM.Prospectos();

            if (!Guid.TryParse(id, out _id))
                return RedirectToAction("Index");

            if (Guid.Empty==_id)
                return RedirectToAction("Index");

            _retvalue = RoachoSLN.BOL.CRM.Prospectos.Obtener(_id,true);
            return View(_retvalue);
        }
    }
}