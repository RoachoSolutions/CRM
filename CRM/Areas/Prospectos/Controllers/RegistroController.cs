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
            
            return View();
        }


        [HttpPost]
        public ActionResult Guardar(RoachoSLN.Entidades.CRM.Prospectos _pros)
        {
            return Json("prueba:2");
        }

    }
}