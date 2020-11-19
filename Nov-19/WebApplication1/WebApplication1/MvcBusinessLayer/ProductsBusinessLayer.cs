using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.ServiceReference1;

namespace WebApplication1.MvcBusinessLayer
{
    public class ProductsBusinessLayer
    {
        public Product GetProductByProductID(int id)
        {
            ProductsServiceClient productsServiceClient = new ProductsServiceClient();
            return productsServiceClient.GetProductByProductID(id);
        }
    }
}

