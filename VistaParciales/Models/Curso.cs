using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VistaParciales.Models
{
    //[Table("CURSOS")]
    public class Curso
    {

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Column("IdCurso")]
        public int IdCurso { get; set; }
        
        //Nombre Cursos
        //[Column("Nombre")]
        public String Nombre { get; set; }

        //Descripcion
        //[Column("Descripcion")]
        public String Descripcion { get; set; }

        // Precio
        //[Column("Precio")]
        public double Precio { get; set; }

        // Num_Horas
        //[Column("Num_Horas")]
        public int Num_Horas { get; set; }

    }
}