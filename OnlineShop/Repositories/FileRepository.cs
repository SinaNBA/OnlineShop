using OnlineShop.Data;
using OnlineShop.Data.Entity;
using OnlineShop.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Repositories
{
    public class FileRepository : IFileRepository
    {
        private readonly ApplicationDbContext _db;

        public FileRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public (bool isSuccess, string message) Delete(File file)
        {
            if (_db.Files.Any(x => x.Id == file.Id))
            {
                _db.Files.Remove(file);
                _db.SaveChanges();
                return (true, "Done");
            }
            else
            {
                return (false, "Entity not found");
            }
        }

        public IEnumerable<File> GetAll()
        {
            return _db.Files.ToList();
        }

        public File GetById(Guid id)
        {
            if (_db.Files.Any(x => x.Id == id))
            {
                return _db.Files.FirstOrDefault(x => x.Id == id);
            }
            else
            {
                return null;
            }
        }

        public (File entity, bool isSuccess, string message) Insert(File file)
        {
            if (file == null)
            {
                return (file, false, "Validation is failed");
            }
            _db.Files.Add(file);
            _db.SaveChanges();
            return (file, true, "Done");
        }

        public (bool isSuccess, string message) Update(File file)
        {
            if (_db.Files.Any(x => x.Id == file.Id))
            {
                _db.Files.Update(file);
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
