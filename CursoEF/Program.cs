using CursoEF.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var alumnos = new AlumnoRepository();
            foreach (var alumno in alumnos.ListAlumno())
            {
                Console.WriteLine(
                    String.Format("El alumno {0}, tiene {1} curso(s), {2} Direcciones y su estado actual es {3} ",
                    alumno.Nombre + " " + alumno.Apellido,
                    alumno.Cursos.Count(),
                    alumno.Direcciones.Count(),
                    alumno.Estado.Nombre)
                    );
                Console.ReadLine();
            }
            var alumno1 = alumnos.getAlumno(2);
            Console.WriteLine(
              String.Format("El alumno {0}, tiene {1} curso(s), {2} Direcciones y su estado actual es {3} ",
              alumno1.Nombre + " " + alumno1.Apellido,
              alumno1.Cursos.Count(),
              alumno1.Direcciones.Count(),
              alumno1.Estado.Nombre)
              );
            Console.ReadLine();

        }
    }
}
