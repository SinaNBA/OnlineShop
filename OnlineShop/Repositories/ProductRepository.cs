using OnlineShop.Data;
using OnlineShop.Data.Entity;
using OnlineShop.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public (bool isSuccess, string message) Delete(Product product)
        {
            if (_db.Products.Any(x => x.Id == product.Id))
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
                return (true, "Done");
            }
            else
            {
                return (false, "Entity not found");
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _db.Products.ToList();
        }

        public Product GetById(Guid id)
        {
            return _db.Products.FirstOrDefault(x => x.Id == id);
        }

        public (Product entity, bool isSuccess, string message) Insert(Product product)
        {
            if (product == null)
            {
                return (product, false, "Validation is failed");
            }
            _db.Products.Add(product);
            _db.SaveChanges();
            return (product, true, "Done");
        }

        public (bool isSuccess, string message) Update(Product product)
        {
            if (_db.Products.Any(x => x.Id == product.Id))
            {
                _db.Products.Update(product);
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
