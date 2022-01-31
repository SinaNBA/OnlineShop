using AutoMapper;
using OnlineShop.Data.Entity;
using OnlineShop.Models.DomainModels;
using OnlineShop.Repositories.Abstractions;
using OnlineShop.Services.Abstractions;
using System;
using System.Collections.Generic;

namespace OnlineShop.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public (bool isSuccess, string message) Delete(ProductModel product)
        {
            var entity = _mapper.Map<Product>(product);
            var result = _productRepository.Delete(entity);
            return result;
        }


        public IEnumerable<ProductModel> GetAll() => _mapper.Map<IEnumerable<ProductModel>>(_productRepository.GetAll());


        public ProductModel GetById(Guid id) => _mapper.Map<ProductModel>(_productRepository.GetById(id));
        //{
        //var entity= _productRepository.GetById(id);
        //var model = _mapper.Map<ProductModel>(entity);
        //return model;
        //return _mapper.Map<ProductModel>(_productRepository.GetById(id));

        //}

        public (ProductModel entity, bool isSuccess, string message) Insert(ProductModel product)
        {
            var entity = _mapper.Map<Product>(product);
            var result = _productRepository.Insert(entity);
            var model = _mapper.Map<ProductModel>(result.entity);
            return (model, result.isSuccess, result.message);
        }

        public (bool isSuccess, string message) Update(ProductModel product)
        {
            var entity = _mapper.Map<Product>(product);
            var result = _productRepository.Update(entity);
            return result;
        }
    }
}
