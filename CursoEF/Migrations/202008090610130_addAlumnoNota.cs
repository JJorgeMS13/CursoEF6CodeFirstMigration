namespace CursoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAlumnoNota : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumno", "PromedioAcumulado", c => c.Decimal(nullable: false, precision: 18, scale: 2, defaultValue: 0));
            AddColumn("dbo.AlumnoCurso", "Nota", c => c.Decimal(nullable: false, precision: 18, scale: 2, defaultValue: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AlumnoCurso", "Nota");
            DropColumn("dbo.Alumno", "PromedioAcumulado");
        }
    }
}
