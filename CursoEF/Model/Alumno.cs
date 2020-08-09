using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Model
{
   public class Alumno
    {

        public Alumno()
        {
            Cursos = new List<AlumnoCurso>();
            Direcciones = new List<AlumnoDireccion>();
        }
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal PromedioAcumulado { get; set; }
        public int? AlumnoEstadoId { get; set; }

        public AlumnoEstado Estado { get; set; }

        [Required]
        public DateTime FechaEmision { get; set; }
        [Required]
        public DateTime FechaUpdate { get; set; }
        public List<AlumnoCurso> Cursos { get; set; }
        public List<AlumnoDireccion> Direcciones { get; set; }
    }
}
