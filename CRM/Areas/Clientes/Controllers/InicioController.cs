using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Areas.Clientes.Controllers
{
    public class InicioController : Controller
    {
        // GET: Clientes/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}