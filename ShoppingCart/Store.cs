using ShoppingCart.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ShoppingCart
{
    internal class Store : IStore
    {
        private List<Product> products;

        public Store()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Apples", Description = "Fruit",Stock =5, Price = 2.5M },
                new Product { Id = 2, Name = "Bread", Description = "Loaf",Stock =10,  Price = 1.35M },
                new Product { Id = 3, Name = "Oranges", Description = "Fruit",Stock =10,  Price = 2.99M },
                new Product { Id = 4, Name = "Milk", Description = "Milk",Stock =3,  Price = 2.07M },
                new Product { Id = 5, Name = "Chocolate", Description = "Bars",Stock =20,  Price = 11.79M }
            };
            this.products = products;
        }
            
        public IEnumerable<Product> GetAllProducts()
        {
            return this.products;
        }
        public IEnumerable<Product> GetProduct(int id)
        {
            if (id == -1)
            { throw new ArgumentNullException("product id <1"); }
            var product = products.FirstOrDefault((p) => p.Id == id);
            yield return product;
        }
        public void AddProduct(Product newProduct)
        {
            if (newProduct == null)
            { throw new ArgumentNullException("newProduct"); }
            products.Add(newProduct);
        }
        public void UpdateProduct(Product uProduct)
        {
            if (uProduct ==null)
            { throw new ArgumentNullException("uProduct"); }
            products.Remove(products.First(p => p.Id.Equals(uProduct.Id)));
            products.Add(uProduct);
            
        }
        public IEnumerable<Product> RemoveProduct(int id)
        {
            if (id == -1)
            { throw new ArgumentNullException("product id <1"); }
            products.Remove(products.First(p => p.Id.Equals(id)));
            return products;
        }
    }
}
