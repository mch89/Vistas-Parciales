using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VistaParciales.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cursos()
        {
            ViewBag.Message = "Cursos 2020";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pagina de Contacto.";

            return View();
        }
        public ActionResult Proyectos()
        {
            ViewBag.Message = "Tu página de proyectos.";

            return View();
        }
    }
}