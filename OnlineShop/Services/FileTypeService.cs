using AutoMapper;
using OnlineShop.Data.Entity;
using OnlineShop.Models.DomainModels;
using OnlineShop.Repositories.Abstractions;
using OnlineShop.Services.Abstractions;
using System.Collections.Generic;

namespace OnlineShop.Services
{
    public class FileTypeService : IFileTypeService
    {
        private readonly IFileTypeRepository _fileTypeRepository;
        private readonly IMapper _mapper;

        public FileTypeService(IFileTypeRepository fileTypeRepository, IMapper mapper)
        {
            _fileTypeRepository = fileTypeRepository;
            _mapper = mapper;
        }

        public (bool isSuccess, string message) Delete(FileTypeModel fileType)
        {
            var entity = _mapper.Map<FileType>(fileType);
            var result = _fileTypeRepository.Delete(entity);
            return result;
        }

        public IEnumerable<FileTypeModel> GetAll()
        {
            return _mapper.Map<IEnumerable<FileTypeModel>>(_fileTypeRepository.GetAll());
        }

        public FileTypeModel GetById(int id)
        {
            return _mapper.Map<FileTypeModel>(_fileTypeRepository.GetById(id));
        }

        public (FileTypeModel entity, bool isSuccess, string message) Insert(FileTypeModel fileType)
        {
            var entity = _mapper.Map<FileType>(fileType);
            var result = _fileTypeRepository.Insert(entity);
            var model = _mapper.Map<FileTypeModel>(result.entity);
            return (model, result.isSuccess, result.message);
        }

        public (bool isSuccess, string message) Update(FileTypeModel fileType)
        {
            var entity = _mapper.Map<FileType>(fileType);
            var result = _fileTypeRepository.Update(entity);
            return result;
        }
    }
}
