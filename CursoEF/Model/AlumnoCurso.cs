using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Model
{
   public class AlumnoCurso
    {

        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public decimal Nota { get; set; }
    }
}
