using OnlineShop.Data.Entity;
using System;
using System.Collections.Generic;

namespace OnlineShop.Repositories.Abstractions
{
    public interface IProductRepository
    {
        (Product entity, bool isSuccess, string message) Insert(Product product);
        (bool isSuccess, string message) Update(Product product);
        (bool isSuccess, string message) Delete(Product product);
        IEnumerable<Product> GetAll();
        Product GetById(Guid id);
    }
}
