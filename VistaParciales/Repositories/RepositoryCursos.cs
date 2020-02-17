using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VistaParciales.Data;
using VistaParciales.Models;

namespace VistaParciales.Repositories
{
    public class RepositoryCursos
    {

        //ContextoCurso contexto;
        //public RepositoryCursos()
        //{
        //    this.contexto = new ContextoCurso();

        //}
        List<Curso> listaCursos = new List<Curso>();

        public RepositoryCursos()
        {
            Curso c1 = new Curso();

            c1.Nombre = "Curso 1";
            c1.Descripcion = "Descripcion curso 1";
            c1.Precio = 12;
            c1.Num_Horas = 15;
            listaCursos.Add(c1);

            Curso c2 = new Curso();
            c2.Nombre = "Curso 2";
            c2.Descripcion = "Descripcion curso 2";
            c2.Precio = 12;
            c2.Num_Horas = 15;
            listaCursos.Add(c2);

            Curso c3 = new Curso();
            c2.Nombre = "Curso 3";
            c2.Descripcion = "Descripcion curso 3";
            c2.Precio = 12;
            c2.Num_Horas = 15;
            listaCursos.Add(c3);




        }


        public List<Curso> GetCursos() {

         return listaCursos;
        }


  }
}