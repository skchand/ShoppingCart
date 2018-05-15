using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart
{
    public class ShoppingBasket :IShoppingBasket
    {
       // private static Dictionary<string, List<Product>> baskets;

        private readonly IStore store;
        public ShoppingBasket(IStore store)
        {
            this.store = store;
        }
        public void AddItemToCart(string cartName, int productId, int quantity)
        {
           //verify if the product is avaiable to cart
           //add product to cart
        }

        public void Checkout(string cartName)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetShoppingCart(string cartName)
        {
            throw new NotImplementedException();
        }
    }
}