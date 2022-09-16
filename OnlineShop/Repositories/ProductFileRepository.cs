using OnlineShop.Data;
using OnlineShop.Data.Entity;
using OnlineShop.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Repositories
{
    public class ProductFileRepository : IProductFileRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductFileRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public (bool isSuccess, string message) Delete(ProductFile productFile)
        {
            if (_db.ProductFiles.Any(x => x.Id == productFile.Id))
            {
                _db.ProductFiles.Remove(productFile);
                _db.SaveChanges();
                return (true, "Done");
            }
            else
            {
                return (false, "Entity not found");
            }
        }

        public IEnumerable<ProductFile> GetAll()
        {
            return _db.ProductFiles.ToList();
        }

        public ProductFile GetById(Guid id)
        {
            return _db.ProductFiles.FirstOrDefault(x => x.Id == id);
        }

        public (ProductFile entity, bool isSuccess, string message) Insert(ProductFile productFile)
        {
            if (productFile == null)
            {
                return (productFile, false, "Validation is failed");
            }
            _db.ProductFiles.Add(productFile);
            _db.SaveChanges();
            return (productFile, true, "Done");
        }

        public (bool isSuccess, string message) Update(ProductFile productFile)
        {
            if (_db.ProductFiles.Any(x => x.Id == productFile.Id))
            {
                _db.ProductFiles.Update(productFile);
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
