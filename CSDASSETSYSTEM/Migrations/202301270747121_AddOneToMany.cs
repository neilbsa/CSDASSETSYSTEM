namespace CSDASSETSYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOneToMany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.People", "DepartmentId");
            AddForeignKey("dbo.People", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.People", new[] { "DepartmentId" });
            DropColumn("dbo.People", "DepartmentId");
        }
    }
}
