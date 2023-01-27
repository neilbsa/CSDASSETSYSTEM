namespace CSDASSETSYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressLinkToPErsonOneToOne4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "AddressId", "dbo.Addresses");
            DropIndex("dbo.People", new[] { "AddressId" });
            DropColumn("dbo.Addresses", "Id");
            RenameColumn(table: "dbo.Addresses", name: "AddressId", newName: "Id");
            DropPrimaryKey("dbo.Addresses");
            AlterColumn("dbo.Addresses", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Addresses", "Id");
            CreateIndex("dbo.Addresses", "Id");
            AddForeignKey("dbo.Addresses", "Id", "dbo.People", "Id");
            DropColumn("dbo.People", "AddressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "AddressId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Addresses", "Id", "dbo.People");
            DropIndex("dbo.Addresses", new[] { "Id" });
            DropPrimaryKey("dbo.Addresses");
            AlterColumn("dbo.Addresses", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Addresses", "Id");
            RenameColumn(table: "dbo.Addresses", name: "Id", newName: "AddressId");
            AddColumn("dbo.Addresses", "Id", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.People", "AddressId");
            AddForeignKey("dbo.People", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
        }
    }
}
