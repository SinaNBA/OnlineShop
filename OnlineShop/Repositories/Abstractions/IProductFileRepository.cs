using OnlineShop.Data.Entity;
using System;
using System.Collections.Generic;

namespace OnlineShop.Repositories.Abstractions
{
    public interface IProductFileRepository
    {
        (ProductFile entity, bool isSuccess, string message) Insert(ProductFile productFile);
        (bool isSuccess, string message) Update(ProductFile productFile);
        (bool isSuccess, string message) Delete(ProductFile productFile);
        IEnumerable<ProductFile> GetAll();
        ProductFile GetById(Guid id);
    }
}
