using AutoMapper;
using OnlineShop.Data.Entity;
using OnlineShop.Models.DomainModels;
using OnlineShop.Repositories.Abstractions;
using OnlineShop.Services.Abstractions;
using System;
using System.Collections.Generic;

namespace OnlineShop.Services
{
    public class ProductFileService : IProductFileService
    {
        private readonly IProductFileRepository _productFileRepository;
        private readonly IMapper _mapper;

        public ProductFileService(IProductFileRepository productFileRepository, IMapper mapper)
        {
            _productFileRepository = productFileRepository;
            _mapper = mapper;
        }
        public (bool isSuccess, string message) Delete(ProductFileModel productFile)
        {
            var entity = _mapper.Map<ProductFile>(productFile);
            var result = _productFileRepository.Delete(entity);
            return result;
        }

        public IEnumerable<ProductFileModel> GetAll()
        {
            return _mapper.Map<IEnumerable<ProductFileModel>>(_productFileRepository.GetAll());
        }

        public ProductFileModel GetById(Guid id)
        {
            return _mapper.Map<ProductFileModel>(_productFileRepository.GetById(id));
        }

        public (ProductFileModel entity, bool isSuccess, string message) Insert(ProductFileModel productFile)
        {
            var entity = _mapper.Map<ProductFile>(productFile);
            var result = _productFileRepository.Insert(entity);
            var model = _mapper.Map<ProductFileModel>(result.entity);
            return (model, result.isSuccess, result.message);
        }

        public (bool isSuccess, string message) Update(ProductFileModel productFile)
        {
            var entity = _mapper.Map<ProductFile>(productFile);
            var result = _productFileRepository.Update(entity);
            return result;
        }
    }
}
