namespace CursoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterAlumnoColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumno", "FechaEmision", c => c.DateTime(nullable: false));
            AddColumn("dbo.Alumno", "FechaUpdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Alumno", "FechaUpdate");
            DropColumn("dbo.Alumno", "FechaEmision");
        }
    }
}
