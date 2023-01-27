namespace CSDASSETSYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssetCode = c.String(),
                        AssetName = c.String(),
                        AssetType = c.String(),
                        Serial = c.String(),
                        model = c.String(),
                        price = c.Double(nullable: false),
                        DatePurchased = c.DateTime(nullable: false),
                        Warranty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        DepartmentCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyID = c.String(),
                        Name = c.String(),
                        Department = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(),
                        BriefIntroduction = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.Departments");
            DropTable("dbo.Assets");
        }
    }
}
