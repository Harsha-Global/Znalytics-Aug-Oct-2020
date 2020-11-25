using eCommerce.WebAPI.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace eCommerce.DataAccessLayer
{
    public class eCommerceDbContext: DbContext
    {
        public eCommerceDbContext(): base("myConnectionString")
        { 
        }
        public DbSet<Customer> Customers { get; set; }
    }
}

