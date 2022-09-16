using OnlineShop.Data;
using OnlineShop.Data.Entity;
using OnlineShop.Repositories.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductCategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public (bool isSuccess, string message) Delete(ProductCategory productCategory)
        {
            if (_db.ProductCategories.Any(x => x.Id == productCategory.Id))
            {
                _db.ProductCategories.Remove(productCategory);
                _db.SaveChanges();
                return (true, "Done");
            }
            else
            {
                return (false, "Entity not found");
            }
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _db.ProductCategories.ToList();
        }

        public ProductCategory GetById(int id)
        {
            return _db.ProductCategories.FirstOrDefault(x => x.Id == id);
        }

        public (ProductCategory entity, bool isSuccess, string message) Insert(ProductCategory productCategory)
        {
            if (productCategory == null || productCategory.Id != 0)
            {
                return (productCategory, false, "Validation is failed");
            }
            _db.ProductCategories.Add(productCategory);
            _db.SaveChanges();
            return (productCategory, true, "Done");
        }

        public (bool isSuccess, string message) Update(ProductCategory productCategory)
        {
            if (_db.ProductCategories.Any(x => x.Id == productCategory.Id))
            {
                _db.ProductCategories.Update(productCategory);
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
