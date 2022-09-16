using AutoMapper;
using OnlineShop.Data.Entity;
using OnlineShop.Models.DomainModels;
using OnlineShop.Repositories.Abstractions;
using OnlineShop.Services.Abstractions;
using System.Collections.Generic;

namespace OnlineShop.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IMapper _mapper;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IMapper mapper)
        {
            _productCategoryRepository = productCategoryRepository;
            _mapper = mapper;
        }
        public (bool isSuccess, string message) Delete(ProductCategoryModel productCategory)
        {
            var entity = _mapper.Map<ProductCategory>(productCategory);
            var result = _productCategoryRepository.Delete(entity);
            return result;
        }

        public IEnumerable<ProductCategoryModel> GetAll()
        {
            return _mapper.Map<IEnumerable<ProductCategoryModel>>(_productCategoryRepository.GetAll());
        }

        public ProductCategoryModel GetById(int id)
        {
            return _mapper.Map<ProductCategoryModel>(_productCategoryRepository.GetById(id));
        }

        public (ProductCategoryModel entity, bool isSuccess, string message) Insert(ProductCategoryModel productCategory)
        {
            var entity = _mapper.Map<ProductCategory>(productCategory);
            var result = _productCategoryRepository.Insert(entity);
            var model = _mapper.Map<ProductCategoryModel>(result.entity);
            return (model, result.isSuccess, result.message);
        }

        public (bool isSuccess, string message) Update(ProductCategoryModel productCategory)
        {
            var entity = _mapper.Map<ProductCategory>(productCategory);
            var result = _productCategoryRepository.Update(entity);
            return result;
        }
    }
}
