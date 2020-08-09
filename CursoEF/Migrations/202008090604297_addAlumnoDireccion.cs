namespace CursoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAlumnoDireccion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlumnoDireccion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Direccion = c.String(nullable: false, unicode: false, storeType: "text"),
                        AlumnoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.AlumnoId, cascadeDelete: true)
                .Index(t => t.AlumnoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AlumnoDireccion", "AlumnoId", "dbo.Alumno");
            DropIndex("dbo.AlumnoDireccion", new[] { "AlumnoId" });
            DropTable("dbo.AlumnoDireccion");
        }
    }
}
