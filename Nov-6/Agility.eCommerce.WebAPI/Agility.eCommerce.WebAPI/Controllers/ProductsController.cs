using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Agility.eCommerce.BusinessLogicLayer;
using Agility.eCommerce.DataLayer;

namespace Agility.eCommerce.WebAPI.Controllers
{
    /// <summary>
    /// Contains Web API Methods for handling requests of "Products" table
    /// </summary>
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ProductsController : ApiController
    {
        // GET: api/Products
        /// <summary>
        /// Get all products sorted by ProductName
        /// </summary>
        /// <returns>List of products sorted by ProductName</returns>
        public List<Product> Get()
        {
            ProductsBusinessLayer productsBusinessLayer = new ProductsBusinessLayer();
            List<Product> products = productsBusinessLayer.GetProducts();
            return products;
        }

        // GET: api/products/id
        /// <summary>
        /// Get product by ProductID
        /// </summary>
        /// <param name="id">ProductID to search</param>
        /// <returns>Get product by ProductID</returns>
        public Product Get(Guid id)
        {
            ProductsBusinessLayer productsBusinessLayer = new ProductsBusinessLayer();
            Product product = productsBusinessLayer.GetProductByProductID(id);
            return product;
        }

        // GET: api/products?ProductName=s
        /// <summary>
        /// Get products by matching product name (contains)
        /// </summary>
        /// <param name="id">ProductName to search</param>
        /// <returns>Get products by matching product name (contains)</returns>
        public List<Product> Get(string ProductName)
        {
            ProductsBusinessLayer productsBusinessLayer = new ProductsBusinessLayer();
            List<Product> products = productsBusinessLayer.GetProductsByProductName(ProductName);
            return products;
        }

        // POST: api/products
        public Product Post([FromBody] Product product)
        {
            ProductsBusinessLayer productsBusinessLayer = new ProductsBusinessLayer();
            Product resultProduct = productsBusinessLayer.InsertProduct(product);
            return resultProduct;
        }

        // PUT: api/products/id
        public Product Put(Guid id, [FromBody]Product product)
        {
            ProductsBusinessLayer productsBusinessLayer = new ProductsBusinessLayer();
            Product resultProduct = productsBusinessLayer.UpdateProduct(product);
            return resultProduct;
        }

        // DELETE: api/products/id
        public int Delete(Guid id)
        {
            ProductsBusinessLayer productsBusinessLayer = new ProductsBusinessLayer();
            int n = productsBusinessLayer.DeleteProduct(id);
            return n;
        }
    }
}
