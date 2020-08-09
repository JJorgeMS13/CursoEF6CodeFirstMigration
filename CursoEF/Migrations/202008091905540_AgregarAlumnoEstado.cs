namespace CursoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarAlumnoEstado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlumnoEstado",
                c => new
                    {
                        AlumnoEstadoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.AlumnoEstadoId);
            
            AddColumn("dbo.Alumno", "AlumnoEstadoId", c => c.Int());
            CreateIndex("dbo.Alumno", "AlumnoEstadoId");
            AddForeignKey("dbo.Alumno", "AlumnoEstadoId", "dbo.AlumnoEstado", "AlumnoEstadoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumno", "AlumnoEstadoId", "dbo.AlumnoEstado");
            DropIndex("dbo.Alumno", new[] { "AlumnoEstadoId" });
            DropColumn("dbo.Alumno", "AlumnoEstadoId");
            DropTable("dbo.AlumnoEstado");
        }
    }
}
