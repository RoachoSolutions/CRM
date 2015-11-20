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
            return View(new RoachoSLN.Entidades.CRM.Prospectos() { id=Guid.NewGuid()});
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