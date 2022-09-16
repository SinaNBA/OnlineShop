using OnlineShop.Data.Entity;
using System;
using System.Collections.Generic;

namespace OnlineShop.Repositories.Abstractions
{
    public interface IFileRepository
    {
        (File entity, bool isSuccess, string message) Insert(File file);
        (bool isSuccess, string message) Update(File file);
        (bool isSuccess, string message) Delete(File file);
        IEnumerable<File> GetAll();
        File GetById(Guid id);
    }
}
