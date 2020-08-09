using CursoEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CursoEF.Controlador
{
   public class AlumnoRepository
    {
        public List<Alumno> ListAlumno()
        {
            using (var ctx = new EfCursoContext())
            {
                return ctx.Alumno
                    .Include(x => x.Direcciones)
                    .Include(x => x.Estado)
                    .Include(x => x.Cursos.Select(y => y.Curso))
                    .ToList();
            }
        }
        public Alumno getAlumno(int id)
        {
            try
            {
                using (var ctx = new EfCursoContext())
                {
                    return ctx.Alumno
                        .Include(x => x.Direcciones)
                        .Include(x => x.Estado)
                        .Include(x => x.Cursos.Select(y => y.Curso)).Where(x => x.AlumnoId == id).SingleOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void saveAlumno(Alumno model)
        {
            try
            {
                using (var cxt = new EfCursoContext())
                {
                    if (model.AlumnoId > 0)
                    {
                        cxt.Entry(model).State = EntityState.Added;
                    }
                    else
                    {
                        cxt.Entry(model).State = EntityState.Modified;
                    }
                    cxt.SaveChanges();
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void deteleAlumno(int id)
        {
            try
            {
                using (var ctx = new EfCursoContext())
                {
                    ctx.Entry(new Alumno { AlumnoId = id }).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
