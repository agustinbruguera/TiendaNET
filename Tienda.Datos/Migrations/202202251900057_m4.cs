namespace Tienda.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ventas", "FechaVenta", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ventas", "FechaVenta", c => c.Int(nullable: false));
        }
    }
}
