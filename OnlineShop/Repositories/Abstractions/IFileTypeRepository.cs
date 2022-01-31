using OnlineShop.Data.Entity;
using System.Collections.Generic;

namespace OnlineShop.Repositories.Abstractions
{
    public interface IFileTypeRepository
    {
        (FileType entity, bool isSuccess, string message) Insert(FileType fileType);
        (bool isSuccess, string message) Update(FileType fileType);
        (bool isSuccess, string message) Delete(FileType fileType);
        IEnumerable<FileType> GetAll();
        FileType GetById(int id);
    }
}
