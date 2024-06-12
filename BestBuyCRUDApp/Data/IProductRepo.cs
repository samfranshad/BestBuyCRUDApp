﻿using BestBuyCRUDApp.Models;

namespace BestBuyCRUDApp.Data
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts();

        public Product GetProduct(int id);

        public void UpdateProduct(Product product);
    }
}
