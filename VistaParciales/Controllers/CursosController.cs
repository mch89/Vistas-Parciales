using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VistaParciales.Models;
using VistaParciales.Repositories;

namespace VistaParciales.Controllers
{
    public class CursosController : Controller
    {

        //REPOSITORIO
        RepositoryCursos repo;

        public CursosController()
        {
            this.repo = new RepositoryCursos();

        }

        public ActionResult _Cursos() {
            List<Curso> listaCurso = this.repo.GetCursos();

            return PartialView(listaCurso);
        }























    }
}