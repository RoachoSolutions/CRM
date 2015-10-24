using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Areas.Prospectos.Controllers
{
    public class JsonController : Controller
    {
        // GET: Prospectos/Ajax
        public ActionResult Index()
        {
            return View();
        }
    }
}