using System;
using System.Collections.Generic;
using System.Linq;

namespace Agility.eCommerce.DataLayer
{
    /// <summary>
    /// Interface for all data layer operations of "Products" table
    /// </summary>
    public interface IProductsDataLayer
    {
        List<Product> GetProducts();
        Product GetProductByProductID(Guid ProductID);
        List<Product> GetProductsByProductName(string ProductName);
        Product InsertProduct(Product product);
        Product UpdateProduct(Product product);
        int DeleteProduct(Guid ProductID);
        void DeleteAllProducts();
    }
}
