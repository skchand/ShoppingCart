using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingCart.Models;

namespace ShoppingCart.Services
{
    public class ProductService : IProductService
    {
        private IStore Store { get; }
        public ProductService(IStore store)
        {
            this.Store = store;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return Store.Products;
        }
        public IEnumerable<Product> GetProduct(int id)
        {
            if (id == -1)
            { throw new ArgumentNullException("product id <1"); }
            var product = Store.Products.FirstOrDefault((p) => p.Id == id);
            yield return product;
        }
        public void AddProduct(Product newProduct)
        {
            if (newProduct == null)
            { throw new ArgumentNullException("newProduct"); }
            Store.Products.Add(newProduct);
        }
        public void UpdateProduct(Product uProduct)
        {
            if (uProduct == null)
            { throw new ArgumentNullException("uProduct"); }
            Store.Products.Remove(Store.Products.First(p => p.Id.Equals(uProduct.Id)));
            Store.Products.Add(uProduct);
        }
        public IEnumerable<Product> RemoveProduct(int id)
        {
            if (id == -1)
            { throw new ArgumentNullException("product id <1"); }
            Store.Products.Remove(Store.Products.First(p => p.Id.Equals(id)));
            return Store.Products;
        }
    }
}