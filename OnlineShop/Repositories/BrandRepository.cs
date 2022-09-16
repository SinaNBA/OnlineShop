using OnlineShop.Data;
using OnlineShop.Data.Entity;
using OnlineShop.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _db;

        public BrandRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public (bool isSuccess, string message) Delete(Brand brand)
        {
            if (_db.Brands.Any(x => x.Id == brand.Id))
            {
                _db.Brands.Remove(brand);
                _db.SaveChanges();
                return (true, "Done");
            }
            else
            {
                return (false, "Entity not found");
            }
        }

        public IEnumerable<Brand> GetAll()
        {
            return _db.Brands.ToList();
        }

        public Brand GetById(int id)
        {
            return _db.Brands.FirstOrDefault(x => x.Id == id);
        }

        public (Brand entity, bool isSuccess, string message) Insert(Brand brand)
        {
            if (brand == null || brand.Id != 0)
            {
                return (brand, false, "Validation is failed");
            }
            _db.Brands.Add(brand);
            _db.SaveChanges();
            return (brand, true, "Done");

        }

        public (bool isSuccess, string message) Update(Brand brand)
        {
            if (_db.Brands.Any(x => x.Id == brand.Id))
            {
                _db.Brands.Update(brand);
                _db.SaveChanges();
                return (true, "Done");
            }
            else
            {
                return (false, "Entity not found");
            }
        }
    }
}
