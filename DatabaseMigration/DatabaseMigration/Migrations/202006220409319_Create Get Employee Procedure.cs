namespace DatabaseMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGetEmployeeProcedure : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
     "dbo.GetEmployee",
     p => new
     {
         EmployeeId = p.Int(),
        
     },
     body:
         @"
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select * from Employees where EmployeeId =@EmployeeId 
END
"
 );
        }
        
        public override void Down()
        {
        }
    }
}
