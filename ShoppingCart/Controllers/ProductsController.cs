using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppingCart.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Apples", Description = "Fruit",Stock =5, Price = 2.5M },
            new Product { Id = 2, Name = "Bread", Description = "Loaf",Stock =10,  Price = 1.35M },
            new Product { Id = 3, Name = "Oranges", Description = "Fruit",Stock =10,  Price = 2.99M },
            new Product { Id = 4, Name = "Milk", Description = "Milk",Stock =3,  Price = 2.07M },
            new Product { Id = 5, Name = "Chocolate", Description = "Bars",Stock =20,  Price = 11.79M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
