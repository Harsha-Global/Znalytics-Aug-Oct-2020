namespace MvcApp.Migrations
{
    using MvcApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcApp.EntityFramework.MvcAppDatabaseDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcApp.EntityFramework.MvcAppDatabaseDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //context.Set<Employee>().AddOrUpdate();

            context.Employees.AddOrUpdate(new Employee() {
                EmpID = Guid.Parse("BADD7BB2-ECCA-477C-9D2A-6ADE573F0E81"),
                EmpName = "Scott", Email = "scott@gmail.com",
                DateOfJoining = Convert.ToDateTime("1995-10-04"), CTCPerHour = 670.8M });

            context.Employees.AddOrUpdate(new Employee() {
                EmpID = Guid.Parse("4CC46A18-8CC7-4D44-BBAA-517F5DAAB123"),
                EmpName = "Allen", Email = "allen@gmail.com",
                DateOfJoining = Convert.ToDateTime("2000-06-10"), CTCPerHour = 950M });

            context.Employees.AddOrUpdate(new Employee() {
                EmpID = Guid.Parse("2D9A44EA-672F-4047-9764-5F9B4AEBD234"),
                EmpName = "Jones", Email = "jones@gmail.com",
                DateOfJoining = Convert.ToDateTime("1995-07-20"), CTCPerHour = 1200M });
        }
    }
}
