using OnlineShop.Models.DomainModels;
using System.Collections.Generic;

namespace OnlineShop.Services.Abstractions
{
    public interface IProductCategoryService
    {
        (ProductCategoryModel entity, bool isSuccess, string message) Insert(ProductCategoryModel productCategory);
        (bool isSuccess, string message) Update(ProductCategoryModel productCategory);
        (bool isSuccess, string message) Delete(ProductCategoryModel productCategory);
        IEnumerable<ProductCategoryModel> GetAll();
        ProductCategoryModel GetById(int id);
    }
}
