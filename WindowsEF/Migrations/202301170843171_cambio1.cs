namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambio1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Habitacions", newName: "Habitaciones");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Habitaciones", newName: "Habitacions");
        }
    }
}
