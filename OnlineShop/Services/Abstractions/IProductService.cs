using OnlineShop.Models.DomainModels;
using System;
using System.Collections.Generic;

namespace OnlineShop.Services.Abstractions
{
    public interface IProductService
    {
        (ProductModel entity, bool isSuccess, string message) Insert(ProductModel product);
        (bool isSuccess, string message) Update(ProductModel product);
        (bool isSuccess, string message) Delete(ProductModel product);
        IEnumerable<ProductModel> GetAll();
        ProductModel GetById(Guid id);
    }
}
