namespace Usuarios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cambios11 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Infoes", newName: "Usuarios");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Usuarios", newName: "Infoes");
        }
    }
}
