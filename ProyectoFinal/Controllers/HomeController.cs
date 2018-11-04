using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Propiedades()
        {
            ViewBag.Message = "Your application goodies page.";

            return View();
        }

        public ActionResult Vehiculos()
        {
            ViewBag.Message = "Your application goodies page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Más información al alcance de su mano.";

            return View();
        }
    }
}