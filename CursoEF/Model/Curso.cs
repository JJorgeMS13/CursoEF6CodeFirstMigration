using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Model
{
   public class Curso
    {
        public int CursoId { get; set; }
        [Required, MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        public DateTime FechaEmision { get; set; }
        [Required]
        public DateTime FechaUpdate { get; set; }
        public List<AlumnoCurso> Alumnos { get; set; }
    }
}
