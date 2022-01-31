using AutoMapper;
using OnlineShop.Data.Entity;
using OnlineShop.Models.DomainModels;
using OnlineShop.Repositories.Abstractions;
using OnlineShop.Services.Abstractions;
using System;
using System.Collections.Generic;

namespace OnlineShop.Services
{
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileRepository;
        private readonly IMapper _mapper;

        public FileService(IFileRepository fileRepository, IMapper mapper)
        {
            _fileRepository = fileRepository;
            _mapper = mapper;
        }
        public (bool isSuccess, string message) Delete(FileModel file)
        {
            var entity = _mapper.Map<File>(file);
            var result = _fileRepository.Delete(entity);
            return result;
        }

        public IEnumerable<FileModel> GetAll()
        {
            return _mapper.Map<IEnumerable<FileModel>>(_fileRepository.GetAll());
        }

        public FileModel GetById(Guid id)
        {
            return _mapper.Map<FileModel>(_fileRepository.GetById(id));
        }

        public (FileModel entity, bool isSuccess, string message) Insert(FileModel file)
        {
            var entity = _mapper.Map<File>(file);
            var result = _fileRepository.Insert(entity);
            var model = _mapper.Map<FileModel>(result.entity);
            return (model, result.isSuccess, result.message);
        }

        public (bool isSuccess, string message) Update(FileModel file)
        {
            var entity = _mapper.Map<File>(file);
            var result = _fileRepository.Update(entity);
            return result;
        }
    }
}
