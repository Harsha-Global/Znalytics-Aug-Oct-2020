using System;
using System.Collections.Generic;
using System.Data.Entity;
using MvcApp.Models;

namespace MvcApp.EntityFramework
{
    /// <summary>
    /// Collection of DbSet's
    /// </summary>
    public class MvcAppDatabaseDbContext : DbContext
    {
        /// <summary>
        /// Provides methods for INSERT, UPDATE, DELETE, SELECT operations on "Employees"
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// Constructor of child class (MvcAppDatabaseDbContext) + supplying 'connection string' to the parent class's constructor
        /// </summary>
        public MvcAppDatabaseDbContext(): base("data source=localhost; integrated security=SSPI; initial catalog=MvcAppDatabase")
        {
        }
    }
}
