using OnlineShop.Data.Entity;
using System.Collections.Generic;

namespace OnlineShop.Repositories.Abstractions
{
    public interface IProductCategoryRepository
    {
        (ProductCategory entity, bool isSuccess, string message) Insert(ProductCategory productCategory);
        (bool isSuccess, string message) Update(ProductCategory productCategory);
        (bool isSuccess, string message) Delete(ProductCategory productCategory);
        IEnumerable<ProductCategory> GetAll();
        ProductCategory GetById(int id);
    }
}
