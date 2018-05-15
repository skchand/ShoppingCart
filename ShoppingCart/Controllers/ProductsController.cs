using ShoppingCart.Models;
using ShoppingCart.Services;
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
        private readonly IProductService productService;

        public ProductsController(IProductService ProductService)
        {
            this.productService = ProductService;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return productService.GetAllProducts();
        }

        [Route("api/products/{id}")]
        [HttpGet]
        public IHttpActionResult GetProduct(int id)
        {
            return Ok(productService.GetProduct(id));
        }

        [HttpPost]
        public void AddProduct(Product newProduct)
        {
            productService.AddProduct(newProduct);
        }

        [HttpPut]
        public void UpdateProduct(Product uProduct)
        {
            productService.UpdateProduct(uProduct);
        }

        [Route ("api/products/{id}")]
        [HttpDelete]
        public IEnumerable<Product> RemoveProduct(int id)
        {
            return productService.RemoveProduct(id);
        }
    }
}
