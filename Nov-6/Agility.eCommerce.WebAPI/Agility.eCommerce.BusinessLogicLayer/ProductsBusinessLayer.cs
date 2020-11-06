using System;
using System.Collections.Generic;
using System.Linq;
using Agility.eCommerce.DataLayer;

namespace Agility.eCommerce.BusinessLogicLayer
{
    public class ProductsBusinessLayer
    {
        /// <summary>
        /// Get all products sorted by ProductName
        /// </summary>
        /// <returns>Returns all products order by ProductName</returns>
        public List<Product> GetProducts()
        {
            IProductsDataLayer productsDataLayer = new ProductsDataLayer();
            List<Product> products = productsDataLayer.GetProducts();
            return products;
        }

        public Product GetProductByProductID(Guid ProductID)
        {
            IProductsDataLayer productsDataLayer = new ProductsDataLayer();
            Product product = productsDataLayer.GetProductByProductID(ProductID);
            return product;
        }

        public List<Product> GetProductsByProductName(string ProductName)
        {
            IProductsDataLayer productsDataLayer = new ProductsDataLayer();
            List<Product> products = productsDataLayer.GetProductsByProductName(ProductName);
            return products;
        }

        public Product InsertProduct(Product product)
        {
            IProductsDataLayer productsDataLayer = new ProductsDataLayer();

            //Initialize essential properties
            product.ProductID = Guid.NewGuid();
            product.DateOfCreation = DateTime.Now;
            product.DateOfModification = DateTime.Now;

            if (product.UnitPrice >= 0)
            {
                //Call InsertProduct of Data Layer
                productsDataLayer.InsertProduct(product);
                return product;
            }
            else
            {
                //throw new Exception();
                return null; //no product is inserted
            }
        }

        public Product UpdateProduct(Product product)
        {
            IProductsDataLayer productsDataLayer = new ProductsDataLayer();

            //Initialize essential properties
            product.DateOfModification = DateTime.Now;

            if (product.UnitPrice >= 0)
            {
                //Call UpdateProduct of Data Layer
                Product resultProduct = productsDataLayer.UpdateProduct(product);
                return resultProduct;
            }
            else
            {
                //throw new Exception();
                return null; //no product is updated
            }
        }

        public int DeleteProduct(Guid ProductID)
        {
            IProductsDataLayer productsDataLayer = new ProductsDataLayer();

            //Call DeleteProduct of Data Layer
            int n = productsDataLayer.DeleteProduct(ProductID);
            return n;
        }

        public void DeleteAllProducts()
        {
            IProductsDataLayer productsDataLayer = new ProductsDataLayer();
            productsDataLayer.DeleteAllProducts();
        }
    }
}

