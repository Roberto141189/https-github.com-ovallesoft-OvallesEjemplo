using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OvallesEjemplo.Controllers
{
    public class SaludoController : Controller
    {
        // GET: Saludo
        public ActionResult Index()
        {
            return View();
        }
    }
}