﻿using ShoppingCart.Models;
using System.Collections.Generic;

namespace ShoppingCart
{
    public interface IStore
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProduct(int id);
        void AddProduct(Product newProduct);
        void UpdateProduct(Product uProduct);
        IEnumerable<Product> RemoveProduct(int id);
    }
}