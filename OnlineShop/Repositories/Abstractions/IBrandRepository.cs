using OnlineShop.Data.Entity;
using System.Collections;
using System.Collections.Generic;

namespace OnlineShop.Repositories.Abstractions
{
    public interface IBrandRepository
    {
        (Brand entity, bool isSuccess, string message) Insert(Brand brand);
        (bool isSuccess, string message) Update(Brand brand);
        (bool isSuccess, string message) Delete(Brand brand);
        IEnumerable<Brand> GetAll();
        Brand GetById(int id);
    }
}
