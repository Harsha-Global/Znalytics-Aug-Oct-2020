using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsWebAPI.Models
{
    /// <summary>
    /// Defines structure of Product model
    /// </summary>
    public class Product
    {
        public int id { get; set; }
        public string productName { get; set; }
        public double price { get; set; }
        public int quantity { get; set; } = 0;
    }
}

