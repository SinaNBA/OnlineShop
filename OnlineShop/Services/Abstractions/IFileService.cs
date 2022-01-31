using OnlineShop.Models.DomainModels;
using System;
using System.Collections.Generic;

namespace OnlineShop.Services.Abstractions
{
    public interface IFileService
    {
        (FileModel entity, bool isSuccess, string message) Insert(FileModel file);
        (bool isSuccess, string message) Update(FileModel file);
        (bool isSuccess, string message) Delete(FileModel file);
        IEnumerable<FileModel> GetAll();
        FileModel GetById(Guid id);
    }
}
