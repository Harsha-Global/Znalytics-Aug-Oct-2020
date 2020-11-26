namespace eCommerce.DataAccessLayer.Migrations
{
    using eCommerce.WebAPI.DomainModels;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eCommerce.DataAccessLayer.eCommerceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(eCommerce.DataAccessLayer.eCommerceDbContext context)
        {
            context.Set<Customer>().AddOrUpdate(new List<Customer>()
            {
                new Customer() { CustomerID = Guid.Parse("4AE2D639-040E-4B00-BADD-51A4F892EBD6"), CustomerName = "customer 1", DateOfJoining = DateTime.Now },
                new Customer() { CustomerID = Guid.Parse("46ECA2B8-3A41-4404-AD4C-26A2F8272D4B"), CustomerName = "customer 2", DateOfJoining = Convert.ToDateTime("2015-08-10") }
            }.ToArray());
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
