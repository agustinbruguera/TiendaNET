namespace Tienda.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ventas", "MontoTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ventas", "MontoTotal", c => c.Int(nullable: false));
        }
    }
}
