using OnlineShop.Models.DomainModels;
using System.Collections.Generic;

namespace OnlineShop.Services.Abstractions
{
    public interface IFileTypeService
    {
        (FileTypeModel entity, bool isSuccess, string message) Insert(FileTypeModel fileType);
        (bool isSuccess, string message) Update(FileTypeModel fileType);
        (bool isSuccess, string message) Delete(FileTypeModel fileType);
        IEnumerable<FileTypeModel> GetAll();
        FileTypeModel GetById(int id);
    }
}
