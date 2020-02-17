using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VistaParciales.Models;

namespace VistaParciales.Data
{
 
    public class ContextoCurso : DbContext
    {

        public ContextoCurso() : base("name=conexiontajamar") { }

        public DbSet<Curso> Cursos { get; set; }
        
    }
}