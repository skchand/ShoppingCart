using ShoppingCart.Models;
using System.Collections.Generic;

namespace ShoppingCart.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProduct(int id);
        void AddProduct(Product newProduct);
        void UpdateProduct(Product uProduct);
        IEnumerable<Product> RemoveProduct(int id);
    }
}
