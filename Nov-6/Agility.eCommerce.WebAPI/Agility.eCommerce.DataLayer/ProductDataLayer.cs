using System;
using System.Collections.Generic;
using System.Linq;

namespace Agility.eCommerce.DataLayer
{
    /// <summary>
    /// This class contains methods of data layers for "Products" table
    /// </summary>
    public class ProductsDataLayer : DataLayerBase<Product>, IProductsDataLayer
    {
        /// <summary>
        /// Get all products sorted by ProductName
        /// </summary>
        /// <returns>Returns all products order by ProductName</returns>
        public List<Product> GetProducts()
        {
            eCommerceEntities db = new eCommerceEntities();
            List<Product> products = db.Products
                .OrderBy(temp => temp.ProductName)
                .ToList();

            return products;
        }

        public Product GetProductByProductID(Guid ProductID)
        {
            eCommerceEntities db = new eCommerceEntities();
            Product matchingProduct = db.Products
                .FirstOrDefault(temp => temp.ProductID == ProductID);

            return base.CheckNullAndReturn(matchingProduct);
        }

        public List<Product> GetProductsByProductName(string ProductName)
        {
            eCommerceEntities db = new eCommerceEntities();
            List<Product> products = db.Products
                .Where(temp => temp.ProductName.Contains(ProductName))
                .OrderBy(temp => temp.ProductName)
                .ToList();

            return products;
        }

        public Product InsertProduct(Product product)
        {
            eCommerceEntities db = new eCommerceEntities();
            db.Products.Add(product);
            db.SaveChanges(); //Generates INSERT query + Execute
            return product;
        }

        public Product UpdateProduct(Product product)
        {
            eCommerceEntities db = new eCommerceEntities();

            //getting data from db
            Product matchingProduct = db.Products.Where(temp => temp.ProductID == product.ProductID).FirstOrDefault();

            if (matchingProduct == null) //ProductID not exists
            {
                return null;
            }
            else
            {
                matchingProduct.ProductName = product.ProductName;
                matchingProduct.UnitPrice = product.UnitPrice;
                matchingProduct.QuantityInStock = product.QuantityInStock;
                matchingProduct.DateOfModification = DateTime.Now;
                db.SaveChanges(); //Generates UPDATE query + Execute
            }

            return matchingProduct;
        }

        public int DeleteProduct(Guid ProductID)
        {
            eCommerceEntities db = new eCommerceEntities();

            //getting data from db
            Product matchingProduct = db.Products.Where(temp => temp.ProductID == ProductID).FirstOrDefault();

            if (matchingProduct == null) //ProductID not exists
            {
                return 0;
            }
            else
            {
                db.Products.Remove(matchingProduct);
                db.SaveChanges(); //Generates DELETE query + Execute
            }

            return 1;
        }

        public void DeleteAllProducts()
        {
            eCommerceEntities db = new eCommerceEntities();

            //deleting all products from the table
            List<Product> products = db.Products.ToList();
            db.Products.RemoveRange(products);
            db.SaveChanges();
        }
    }
}
