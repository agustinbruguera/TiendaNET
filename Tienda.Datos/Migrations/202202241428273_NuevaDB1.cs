namespace Tienda.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevaDB1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LineaDeVentas", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.LineaDeVentas", "Producto_Id", "dbo.Productoes");
            DropForeignKey("dbo.LineaDeVentas", "Talle_Id", "dbo.Talles");
            DropForeignKey("dbo.LineaDeVentas", "Venta_Id", "dbo.Ventas");
            DropIndex("dbo.LineaDeVentas", new[] { "Color_Id" });
            DropIndex("dbo.LineaDeVentas", new[] { "Producto_Id" });
            DropIndex("dbo.LineaDeVentas", new[] { "Talle_Id" });
            DropIndex("dbo.LineaDeVentas", new[] { "Venta_Id" });
            RenameColumn(table: "dbo.LineaDeVentas", name: "Color_Id", newName: "ColorId");
            RenameColumn(table: "dbo.LineaDeVentas", name: "Producto_Id", newName: "ProductoId");
            RenameColumn(table: "dbo.LineaDeVentas", name: "Talle_Id", newName: "TalleId");
            RenameColumn(table: "dbo.LineaDeVentas", name: "Venta_Id", newName: "VentaId");
            AlterColumn("dbo.LineaDeVentas", "ColorId", c => c.Int(nullable: false));
            AlterColumn("dbo.LineaDeVentas", "ProductoId", c => c.Int(nullable: false));
            AlterColumn("dbo.LineaDeVentas", "TalleId", c => c.Int(nullable: false));
            AlterColumn("dbo.LineaDeVentas", "VentaId", c => c.Int(nullable: false));
            CreateIndex("dbo.LineaDeVentas", "VentaId");
            CreateIndex("dbo.LineaDeVentas", "ProductoId");
            CreateIndex("dbo.LineaDeVentas", "TalleId");
            CreateIndex("dbo.LineaDeVentas", "ColorId");
            AddForeignKey("dbo.LineaDeVentas", "ColorId", "dbo.Colors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LineaDeVentas", "ProductoId", "dbo.Productoes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LineaDeVentas", "TalleId", "dbo.Talles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LineaDeVentas", "VentaId", "dbo.Ventas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LineaDeVentas", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.LineaDeVentas", "TalleId", "dbo.Talles");
            DropForeignKey("dbo.LineaDeVentas", "ProductoId", "dbo.Productoes");
            DropForeignKey("dbo.LineaDeVentas", "ColorId", "dbo.Colors");
            DropIndex("dbo.LineaDeVentas", new[] { "ColorId" });
            DropIndex("dbo.LineaDeVentas", new[] { "TalleId" });
            DropIndex("dbo.LineaDeVentas", new[] { "ProductoId" });
            DropIndex("dbo.LineaDeVentas", new[] { "VentaId" });
            AlterColumn("dbo.LineaDeVentas", "VentaId", c => c.Int());
            AlterColumn("dbo.LineaDeVentas", "TalleId", c => c.Int());
            AlterColumn("dbo.LineaDeVentas", "ProductoId", c => c.Int());
            AlterColumn("dbo.LineaDeVentas", "ColorId", c => c.Int());
            RenameColumn(table: "dbo.LineaDeVentas", name: "VentaId", newName: "Venta_Id");
            RenameColumn(table: "dbo.LineaDeVentas", name: "TalleId", newName: "Talle_Id");
            RenameColumn(table: "dbo.LineaDeVentas", name: "ProductoId", newName: "Producto_Id");
            RenameColumn(table: "dbo.LineaDeVentas", name: "ColorId", newName: "Color_Id");
            CreateIndex("dbo.LineaDeVentas", "Venta_Id");
            CreateIndex("dbo.LineaDeVentas", "Talle_Id");
            CreateIndex("dbo.LineaDeVentas", "Producto_Id");
            CreateIndex("dbo.LineaDeVentas", "Color_Id");
            AddForeignKey("dbo.LineaDeVentas", "Venta_Id", "dbo.Ventas", "Id");
            AddForeignKey("dbo.LineaDeVentas", "Talle_Id", "dbo.Talles", "Id");
            AddForeignKey("dbo.LineaDeVentas", "Producto_Id", "dbo.Productoes", "Id");
            AddForeignKey("dbo.LineaDeVentas", "Color_Id", "dbo.Colors", "Id");
        }
    }
}
