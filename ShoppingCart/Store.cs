using ShoppingCart.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using ShoppingCart.Services;

namespace ShoppingCart
{
    public class Store : IStore
    {
        public List<Product> Products { get; set; }
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
            this.Products = products;
        }
       
    }
}
