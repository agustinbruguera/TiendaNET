namespace Tienda.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevaDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cuit = c.Int(nullable: false),
                        RazonSocial = c.String(),
                        Domicilio = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LineaDeVentas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Color_Id = c.Int(),
                        Producto_Id = c.Int(),
                        Talle_Id = c.Int(),
                        Venta_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.Color_Id)
                .ForeignKey("dbo.Productoes", t => t.Producto_Id)
                .ForeignKey("dbo.Talles", t => t.Talle_Id)
                .ForeignKey("dbo.Ventas", t => t.Venta_Id)
                .Index(t => t.Color_Id)
                .Index(t => t.Producto_Id)
                .Index(t => t.Talle_Id)
                .Index(t => t.Venta_Id);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoProducto = c.Int(nullable: false),
                        DescripcionProducto = c.String(),
                        PrecioVenta = c.Int(nullable: false),
                        MarcaId = c.Int(nullable: false),
                        RubroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.MarcaId, cascadeDelete: true)
                .ForeignKey("dbo.Rubroes", t => t.RubroId, cascadeDelete: true)
                .Index(t => t.MarcaId)
                .Index(t => t.RubroId);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rubroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        TalleId = c.Int(nullable: false),
                        ColorId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Sucursal_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Talles", t => t.TalleId, cascadeDelete: true)
                .ForeignKey("dbo.Sucursals", t => t.Sucursal_Id)
                .Index(t => t.TalleId)
                .Index(t => t.ColorId)
                .Index(t => t.ProductoId)
                .Index(t => t.Sucursal_Id);
            
            CreateTable(
                "dbo.Talles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumVenta = c.Int(nullable: false),
                        FechaVenta = c.Int(nullable: false),
                        MontoTotal = c.Int(nullable: false),
                        PuntoDeVentaId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.PuntoDeVentas", t => t.PuntoDeVentaId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.PuntoDeVentaId)
                .Index(t => t.UsuarioId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.PuntoDeVentas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        numPtoVta = c.Int(nullable: false),
                        Sucursal_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sucursals", t => t.Sucursal_Id)
                .Index(t => t.Sucursal_Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Pass = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sucursals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "Sucursal_Id", "dbo.Sucursals");
            DropForeignKey("dbo.PuntoDeVentas", "Sucursal_Id", "dbo.Sucursals");
            DropForeignKey("dbo.Ventas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Ventas", "PuntoDeVentaId", "dbo.PuntoDeVentas");
            DropForeignKey("dbo.LineaDeVentas", "Venta_Id", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.LineaDeVentas", "Talle_Id", "dbo.Talles");
            DropForeignKey("dbo.LineaDeVentas", "Producto_Id", "dbo.Productoes");
            DropForeignKey("dbo.Stocks", "TalleId", "dbo.Talles");
            DropForeignKey("dbo.Stocks", "ProductoId", "dbo.Productoes");
            DropForeignKey("dbo.Stocks", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.Productoes", "RubroId", "dbo.Rubroes");
            DropForeignKey("dbo.Productoes", "MarcaId", "dbo.Marcas");
            DropForeignKey("dbo.LineaDeVentas", "Color_Id", "dbo.Colors");
            DropIndex("dbo.PuntoDeVentas", new[] { "Sucursal_Id" });
            DropIndex("dbo.Ventas", new[] { "ClienteId" });
            DropIndex("dbo.Ventas", new[] { "UsuarioId" });
            DropIndex("dbo.Ventas", new[] { "PuntoDeVentaId" });
            DropIndex("dbo.Stocks", new[] { "Sucursal_Id" });
            DropIndex("dbo.Stocks", new[] { "ProductoId" });
            DropIndex("dbo.Stocks", new[] { "ColorId" });
            DropIndex("dbo.Stocks", new[] { "TalleId" });
            DropIndex("dbo.Productoes", new[] { "RubroId" });
            DropIndex("dbo.Productoes", new[] { "MarcaId" });
            DropIndex("dbo.LineaDeVentas", new[] { "Venta_Id" });
            DropIndex("dbo.LineaDeVentas", new[] { "Talle_Id" });
            DropIndex("dbo.LineaDeVentas", new[] { "Producto_Id" });
            DropIndex("dbo.LineaDeVentas", new[] { "Color_Id" });
            DropTable("dbo.Sucursals");
            DropTable("dbo.Usuarios");
            DropTable("dbo.PuntoDeVentas");
            DropTable("dbo.Ventas");
            DropTable("dbo.Talles");
            DropTable("dbo.Stocks");
            DropTable("dbo.Rubroes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Productoes");
            DropTable("dbo.LineaDeVentas");
            DropTable("dbo.Colors");
            DropTable("dbo.Clientes");
        }
    }
}
