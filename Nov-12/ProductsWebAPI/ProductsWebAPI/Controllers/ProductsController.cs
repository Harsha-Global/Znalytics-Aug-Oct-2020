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
                new Product() { id = 1, productName = "Bluetooth Head phones", price = 2300, quantity = 0 },
                new Product() { id = 2, productName = "iPhone 12", price = 44750, quantity = 0 },
                new Product() { id = 3, productName = "Lenovo Keyboard", price = 780, quantity = 0 },
                new Product() { id = 4, productName = "Dell Monitor", price = 12450, quantity = 0 },
                new Product() { id = 5, productName = "Sony Camera", price = 22450, quantity = 0 }
            };

            return products;
        }
    }
}
