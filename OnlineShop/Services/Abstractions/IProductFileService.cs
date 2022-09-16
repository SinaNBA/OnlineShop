using OnlineShop.Models.DomainModels;
using System;
using System.Collections.Generic;

namespace OnlineShop.Services.Abstractions
{
    public interface IProductFileService
    {
        (ProductFileModel entity, bool isSuccess, string message) Insert(ProductFileModel productFile);
        (bool isSuccess, string message) Update(ProductFileModel productFile);
        (bool isSuccess, string message) Delete(ProductFileModel productFile);
        IEnumerable<ProductFileModel> GetAll();
        ProductFileModel GetById(Guid id);
    }
}
