namespace DatabaseMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsPermentColumninEmployeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "IsPermanent", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "IsPermanent");
        }
    }
}
