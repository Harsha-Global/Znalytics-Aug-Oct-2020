using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace eCommerce.WebAPI.DomainModels
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [Column("id")]
        public Guid CustomerID { get; set; }
        public string CustomerName { get; set; }
        public  Nullable<DateTime> DateOfJoining { get; set; }
    }
}

