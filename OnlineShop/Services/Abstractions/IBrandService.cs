using OnlineShop.Models.DomainModels;
using System.Collections.Generic;

namespace OnlineShop.Services.Abstractions
{
    public interface IBrandService
    {
        (BrandModel entity, bool isSuccess, string message) Insert(BrandModel brand);
        (bool isSuccess, string message) Update(BrandModel brand);
        (bool isSuccess, string message) Delete(BrandModel brand);
        IEnumerable<BrandModel> GetAll();
        BrandModel GetById(int id);
    }
}
