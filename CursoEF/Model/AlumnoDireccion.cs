using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Model
{
   public class AlumnoDireccion
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Nombre { get; set; }
        [Required, Column(TypeName ="text")]
        public string Direccion { get; set; }

        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
    }
}
