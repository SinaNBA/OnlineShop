using AutoMapper;
using OnlineShop.Data.Entity;
using OnlineShop.Models.DomainModels;
using OnlineShop.Repositories.Abstractions;
using OnlineShop.Services.Abstractions;
using System.Collections.Generic;

namespace OnlineShop.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public BrandService(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public (bool isSuccess, string message) Delete(BrandModel brand)
        {
            var entity = _mapper.Map<Brand>(brand);
            var result = _brandRepository.Delete(entity);
            return result;
        }

        public IEnumerable<BrandModel> GetAll()
        {
            return _mapper.Map<IEnumerable<BrandModel>>(_brandRepository.GetAll());
        }

        public BrandModel GetById(int id)
        {
            return _mapper.Map<BrandModel>(_brandRepository.GetById(id));
        }

        public (BrandModel entity, bool isSuccess, string message) Insert(BrandModel brand)
        {
            var entity = _mapper.Map<Brand>(brand);
            var result = _brandRepository.Insert(entity);
            var model = _mapper.Map<BrandModel>(result.entity);
            return (model, result.isSuccess, result.message);
        }

        public (bool isSuccess, string message) Update(BrandModel brand)
        {
            var entity = _mapper.Map<Brand>(brand);
            var result = _brandRepository.Update(entity);
            return result;
        }
    }
}
