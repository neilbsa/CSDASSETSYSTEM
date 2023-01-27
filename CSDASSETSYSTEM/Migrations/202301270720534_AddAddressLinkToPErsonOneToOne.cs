namespace CSDASSETSYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressLinkToPErsonOneToOne : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        Block = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        Brgy = c.String(),
                        ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "PersonId", "dbo.People");
            DropIndex("dbo.Addresses", new[] { "PersonId" });
            DropTable("dbo.Addresses");
        }
    }
}
