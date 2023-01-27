namespace CSDASSETSYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManyToMany1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductNumber = c.String(),
                        ProductDescription = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reciepts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalAmount = c.Double(nullable: false),
                        Reference = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RecieptsProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RcptId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Reciepts", t => t.RcptId, cascadeDelete: true)
                .Index(t => t.RcptId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecieptsProducts", "RcptId", "dbo.Reciepts");
            DropForeignKey("dbo.RecieptsProducts", "ProductId", "dbo.Products");
            DropIndex("dbo.RecieptsProducts", new[] { "ProductId" });
            DropIndex("dbo.RecieptsProducts", new[] { "RcptId" });
            DropTable("dbo.RecieptsProducts");
            DropTable("dbo.Reciepts");
            DropTable("dbo.Products");
        }
    }
}
