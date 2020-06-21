namespace DatabaseMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removegenderfromEmployeeTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "Gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Gender", c => c.String(maxLength: 200));
        }
    }
}
