namespace CursoEF.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class EfCursoContext : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'EfCursoContext' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'CursoEF.Model.EfCursoContext' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'EfCursoContext'  en el archivo de configuración de la aplicación.
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<AlumnoCurso> AlumnoCurso { get; set; }
        public EfCursoContext()
            : base("name=EfCursoContext")
        {
        }

        //Metodo que nos ayuda a cambiar la creacion de  las tablas
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Se quita la plurizacion de los nombres de tablas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Se le dice como construir los campos de las diferentes clases
            #region Alumno
            modelBuilder.Entity<Alumno>()
                .Property(x => x.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Alumno>()
                .Property(x => x.Apellido)
                .HasMaxLength(50)
                .IsRequired();
            #endregion
            #region AlumnoCurso
            modelBuilder.Entity<AlumnoCurso>()
                .HasKey(x => new { x.AlumnoId, x.CursoId });
            #endregion
        }
        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}