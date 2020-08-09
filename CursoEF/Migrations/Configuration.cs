namespace CursoEF.Migrations
{
    using CursoEF.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CursoEF.Model.EfCursoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        //Se insertan registros en la base de datos desde C#
        protected override void Seed(CursoEF.Model.EfCursoContext context)
        {
            context.Alumno.AddOrUpdate(
            new Alumno { AlumnoId= 1 ,Nombre = "Jorge", Apellido = "Martinez", FechaEmision = DateTime.Now, FechaUpdate = DateTime.Now },
            new Alumno { AlumnoId= 2, Nombre = "Javier", Apellido = "Lopez", FechaEmision = DateTime.Now, FechaUpdate = DateTime.Now });
            context.Curso.AddOrUpdate(
            new Curso { CursoId = 1, Nombre = "JavaScript", FechaEmision = DateTime.Now, FechaUpdate = DateTime.Now },
            new Curso { CursoId = 2, Nombre = "ASP.NET MVC 6", FechaEmision = DateTime.Now, FechaUpdate = DateTime.Now },
            new Curso { CursoId = 3,Nombre = "EF6", FechaEmision = DateTime.Now, FechaUpdate = DateTime.Now });
            context.AlumnoEstado.AddOrUpdate(
             new AlumnoEstado { AlumnoEstadoId = 1, Nombre = "Matriculado"},
             new AlumnoEstado { AlumnoEstadoId = 2, Nombre = "Retirado" },
             new AlumnoEstado { AlumnoEstadoId = 3, Nombre = "Egresado" });
        }
    }
}
