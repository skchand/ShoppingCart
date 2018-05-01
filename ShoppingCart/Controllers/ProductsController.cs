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
        private readonly IStore store;

        public ProductsController(IStore store)
        {
            this.store = store;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return store.GetAllProducts();
        }

        [Route("api/products/{id}")]
        [HttpGet]
        public IEnumerable<Product> GetProduct(int id)
        {
            return store.GetProduct(id);
        }

        [HttpPost]
        public void AddProduct(Product newProduct)
        {
            store.AddProduct(newProduct);
        }

        [HttpPut]
        public void UpdateProduct(Product uProduct)
        {
            store.UpdateProduct(uProduct);
        }
        [Route ("api/products/{id}")]
        [HttpDelete]
        public IEnumerable<Product> RemoveProduct(int id)
        {
            return store.RemoveProduct(id);
        }
      
    }
}
