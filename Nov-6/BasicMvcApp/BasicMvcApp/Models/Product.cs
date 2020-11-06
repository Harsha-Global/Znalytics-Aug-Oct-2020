using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicMvcApp.Models
{
    /// <summary>
    /// Model class that represents a product
    /// </summary>
    public class Product
    {
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}

//Model: A class that reflects structure of data