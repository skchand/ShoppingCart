using ShoppingCart.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace ShoppingCart
{
    public interface IStore
    {
        List<Product> Products { get; set; }
    }
}