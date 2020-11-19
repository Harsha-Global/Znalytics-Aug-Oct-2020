using System;
using System.Collections.Generic;
using System.Linq;

namespace Company
{
    public class ProductsService : IProductsService
    {
        //list of products
        List<Product> products = null;

        /// <summary>
        /// Constructor of ProductsService class that executes when the request is received from any client
        /// </summary>
        public ProductsService()
        {
            this.products = new List<Product>() { 
                new Product() { ProductID = 1, ProductName = "Product 1", Price = 1000 },
                new Product() { ProductID = 2, ProductName = "Product 2", Price = 2000 },
                new Product() { ProductID = 3, ProductName = "Product 3", Price = 3000 },
                new Product() { ProductID = 4, ProductName = "Product 4", Price = 4000 }
            };
        }
        public Product GetProductByProductID(int id)
        {
            return this.products.FirstOrDefault(temp => temp.ProductID == id);
        }
    }
}


