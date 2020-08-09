namespace CursoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCurso : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlumnoCurso",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AlumnoId, t.CursoId })
                .ForeignKey("dbo.Alumno", t => t.AlumnoId, cascadeDelete: true)
                .ForeignKey("dbo.Curso", t => t.CursoId, cascadeDelete: true)
                .Index(t => t.AlumnoId)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        FechaEmision = c.DateTime(nullable: false),
                        FechaUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CursoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AlumnoCurso", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.AlumnoCurso", "AlumnoId", "dbo.Alumno");
            DropIndex("dbo.AlumnoCurso", new[] { "CursoId" });
            DropIndex("dbo.AlumnoCurso", new[] { "AlumnoId" });
            DropTable("dbo.Curso");
            DropTable("dbo.AlumnoCurso");
        }
    }
}
