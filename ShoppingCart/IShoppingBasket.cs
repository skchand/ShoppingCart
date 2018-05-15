using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public interface IShoppingBasket
    {
        void AddItemToCart(string cartName, int productId, int quantity);
        void Checkout(string cartName);
        List<Product> GetShoppingCart(string cartName);
    }
}
