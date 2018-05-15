using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppingCart.Controllers
{
    public class CartController : ApiController
    {
        private readonly IShoppingBasket _shoppingBasket;
        public CartController(IShoppingBasket shoppingBasket)
        {
            _shoppingBasket = shoppingBasket;
        }

        [Route("api/ShoppingBasket/{cartname}")]
        [HttpGet]
        public IEnumerable<Product> Get(string cartName)
        {
            var shoppingBasket = _shoppingBasket.GetShoppingCart(cartName);
            return shoppingBasket;
        }


        [Route("api/ShoppingBasket/{cartname}/Checkout")]
        [HttpGet]
        [HttpPost]
        public IHttpActionResult CheckOut(string cartName)
        {
            _shoppingBasket.Checkout(cartName);
            return Ok();
        }

        [Route("api/ShoppingBasket/{cartname}/Add/{productId}/{quantity}")]
        [HttpGet]
        [HttpPut]
        public IHttpActionResult AddItemToCart(string cartName, int productId, int quantity)
        {
            _shoppingBasket.AddItemToCart(cartName, productId, quantity);
            return Ok();
        }
    }
}
