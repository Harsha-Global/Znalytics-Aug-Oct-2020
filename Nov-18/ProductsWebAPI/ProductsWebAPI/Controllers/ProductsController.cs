using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ProductsWebAPI.Models;

namespace ProductsWebAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ProductsController : ApiController
    {
        public List<Product> Get()
        {
            List<Product> products = new List<Product>() {
                new Product() { id = 5, productName = "Sony Camera", price = 22450, quantity = 54 },
                new Product() { id = 2, productName = "iPhone 12", price = 44750, quantity = 95 },
                new Product() { id = 6, productName = "dell Keyboard", price = 950, quantity = 45 },
                new Product() { id = 7, productName = null, price = 10000, quantity = 91 },
                new Product() { id = 3, productName = "Lenovo Keyboard", price = 780, quantity = 14 },
                new Product() { id = 1, productName = "Bluetooth Head phones", price = 2300, quantity = 7 },
                new Product() { id = 4, productName = "Dell Monitor", price = 12450, quantity = 24 },
                new Product() { id = 8, productName = "product 8", price = 4500, quantity = 98 },
                new Product() { id = 9, productName = "product 9", price = 4500, quantity = 150 },
                new Product() { id = 10, productName = "product 10", price = 4500, quantity = 77 },
                new Product() { id = 11, productName = "product 11", price = 1500, quantity = 48 },
                new Product() { id = 12, productName = "product 12", price = 800, quantity = 95 },
                new Product() { id = 13, productName = "product 13", price = 9500, quantity = 33 },
                new Product() { id = 14, productName = "product 14", price = 9450, quantity = 12 },
                new Product() { id = 15, productName = "product 15", price = 7744, quantity = 0 },
                new Product() { id = 16, productName = "product 16", price = 3500, quantity = 5 },
                new Product() { id = 17, productName = "product 17", price = 1500, quantity = 10 },
                new Product() { id = 18, productName = "product 18", price = 4800, quantity = 80 },
                new Product() { id = 19, productName = "product 19", price = 4500, quantity = 150 },
                new Product() { id = 20, productName = "product 20", price = 4500, quantity = 77 },
                new Product() { id = 21, productName = "product 21", price = 1500, quantity = 48 },
                new Product() { id = 23, productName = "product 22", price = 800, quantity = 95 },
                new Product() { id = 24, productName = "product 23", price = 9500, quantity = 33 },
                new Product() { id = 25, productName = "product 24", price = 9450, quantity = 12 },
                new Product() { id = 26, productName = "product 25", price = 7744, quantity = 0 },
                new Product() { id = 27, productName = "product 26", price = 3500, quantity = 5 },
                new Product() { id = 28, productName = "product 27", price = 1500, quantity = 10 },
                new Product() { id = 29, productName = "product 28", price = 4800, quantity = 80 },
                new Product() { id = 30, productName = "product 30", price = 4500, quantity = 77 },
                new Product() { id = 31, productName = "product 31", price = 1500, quantity = 48 },
                new Product() { id = 32, productName = "product 32", price = 800, quantity = 95 },
                new Product() { id = 33, productName = "product 33", price = 9500, quantity = 33 },
                new Product() { id = 34, productName = "product 34", price = 9450, quantity = 12 },
                new Product() { id = 35, productName = "product 35", price = 7744, quantity = 0 },
                new Product() { id = 36, productName = "product 36", price = 3500, quantity = 5 },
                new Product() { id = 37, productName = "product 37", price = 1500, quantity = 10 },
                new Product() { id = 38, productName = "product 38", price = 4800, quantity = 80 },
                new Product() { id = 39, productName = "product 39", price = 4500, quantity = 150 },
                new Product() { id = 40, productName = "product 40", price = 4500, quantity = 77 },
                new Product() { id = 41, productName = "product 41", price = 1500, quantity = 48 },
                new Product() { id = 42, productName = "product 42", price = 800, quantity = 95 },
                new Product() { id = 43, productName = "product 43", price = 9500, quantity = 33 },
                new Product() { id = 44, productName = "product 44", price = 9450, quantity = 12 },
                new Product() { id = 45, productName = "product 45", price = 7744, quantity = 0 },
                new Product() { id = 46, productName = "product 46", price = 3500, quantity = 5 },
                new Product() { id = 47, productName = "product 47", price = 1500, quantity = 10 },
                new Product() { id = 48, productName = "product 48", price = 4800, quantity = 80 },
            };

            return products;
        }
    }
}
