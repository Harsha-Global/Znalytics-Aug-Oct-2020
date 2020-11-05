using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Agility.eCommerce.DataLayer;
using Agility.eCommerce.BusinessLogicLayer;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class ProductsUnitTest
    {
        [TestMethod]
        public void ClearTable()
        {
            //Arrange
            ProductsBusinessLayer productsBusinessLayer = new ProductsBusinessLayer();

            //Act
            productsBusinessLayer.DeleteAllProducts();
            List<Product> products = productsBusinessLayer.GetProducts();

            //Assert (test)
            Assert.AreEqual(0, products.Count);
        }

        /// <summary>
        /// After inserting first row, the table should contain one row
        /// </summary>
        [TestMethod]
        public void InsertFirstRow()
        {
            //Arrange
            ProductsBusinessLayer productsBusinessLayer = new ProductsBusinessLayer();

            //Act
            Product product = new Product() { ProductName = "Prod 1", UnitPrice = 10, QuantityInStock = 100 };
            productsBusinessLayer.InsertProduct(product);
            List<Product> products = productsBusinessLayer.GetProducts();

            //Assert (test)
            Assert.AreEqual(1, products.Count);
        }

        /// <summary>
        /// After inserting second row, the table should contain two rows
        /// </summary>
        [TestMethod]
        public void InsertSecondRow()
        {
            //Arrange
            ProductsBusinessLayer productsBusinessLayer = new ProductsBusinessLayer();

            //Act
            Product product = new Product() { ProductName = "Prod 2", UnitPrice = 20, QuantityInStock = 200 };
            productsBusinessLayer.InsertProduct(product);
            List<Product> products = productsBusinessLayer.GetProducts();

            //Assert (test)
            Assert.AreEqual(2, products.Count);
        }

        /// <summary>
        /// After inserting third row, the with wrong price, table should contain two rows
        /// </summary>
        [TestMethod]
        public void InsertThirdRowWithWrongPrice()
        {
            //Arrange
            ProductsBusinessLayer productsBusinessLayer = new ProductsBusinessLayer();

            //Act
            Product product = new Product() { ProductName = "Prod 3", UnitPrice = -10, QuantityInStock = 200 };
            productsBusinessLayer.InsertProduct(product);
            List<Product> products = productsBusinessLayer.GetProducts();

            //Assert (test)
            Assert.AreEqual(2, products.Count);
        }
    }
}
