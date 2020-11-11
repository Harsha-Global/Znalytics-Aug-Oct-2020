namespace MvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Guid(nullable: false),
                        EmpName = c.String(nullable: false, maxLength: 40),
                        Email = c.String(),
                        CTCPerHour = c.Decimal(precision: 18, scale: 2),
                        DateOfJoining = c.DateTime(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
