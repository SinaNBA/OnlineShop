using OnlineShop.Data;
using OnlineShop.Data.Entity;
using OnlineShop.Repositories.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Repositories
{
    public class FileTypeRepository : IFileTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public FileTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public (bool isSuccess, string message) Delete(FileType fileType)
        {
            if (_db.FileTypes.Any(x => x.Id == fileType.Id))
            {
                _db.FileTypes.Remove(fileType);
                _db.SaveChanges();
                return (true, "Done");
            }
            else
            {
                return (false, "Entity not found");
            }
        }

        public IEnumerable<FileType> GetAll()
        {
            return _db.FileTypes.ToList();
        }

        public FileType GetById(int id)
        {
            return _db.FileTypes.FirstOrDefault(x => x.Id == id);
        }

        public (FileType entity, bool isSuccess, string message) Insert(FileType fileType)
        {
            if (fileType == null || fileType.Id != 0)
            {
                return (fileType, false, "Validation is failed");
            }
            _db.FileTypes.Add(fileType);
            _db.SaveChanges();
            return (fileType, true, "Done");
        }

        public (bool isSuccess, string message) Update(FileType fileType)
        {
            if (_db.FileTypes.Any(x => x.Id == fileType.Id))
            {
                _db.FileTypes.Update(fileType);
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
