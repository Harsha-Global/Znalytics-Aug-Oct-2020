namespace MvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DOJNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "DateOfJoining", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "DateOfJoining", c => c.DateTime());
        }
    }
}
