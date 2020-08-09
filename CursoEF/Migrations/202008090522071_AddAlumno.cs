namespace CursoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAlumno : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AlumnoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alumno");
        }
    }
}
