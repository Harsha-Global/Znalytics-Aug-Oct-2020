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

            context.Set<User>().AddOrUpdate(new List<User>()
            {
                new User() { UserID = Guid.Parse("1CDC889C-90F9-4F08-B26A-5AFD9F6FA8A8"), Email = "scott@gmail.com", Password = "d94257ba64ff88eeb6635fec3c5654acba7fa2bf14d00f1c8bf75c31d209f0d2", FullName = "Scott" },
                new User() { UserID = Guid.Parse("459FE903-8B11-4599-B4F2-B151FEF736D2"), Email = "allen@gmail.com", Password = "7d2ad2f73b51c875d301ae7c57f19772d628771b330a67a750701bdedcd37d5e", FullName = "Allen" },
            }.ToArray());
        }
    }
}
