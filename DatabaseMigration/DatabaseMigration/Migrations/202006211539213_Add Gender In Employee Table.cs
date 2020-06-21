namespace DatabaseMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderInEmployeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Gender", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Gender");
        }
    }
}
