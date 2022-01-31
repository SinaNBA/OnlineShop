using AutoMapper;
using OnlineShop.Data.Entity;
using OnlineShop.Models.DomainModels;

namespace OnlineShop
{
    public static class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Product, ProductModel>().ReverseMap();
                config.CreateMap<Brand, BrandModel>().ReverseMap();
                config.CreateMap<File, FileModel>().ReverseMap();
                config.CreateMap<FileType, FileTypeModel>().ReverseMap();
                config.CreateMap<ProductCategory, ProductCategoryModel>().ReverseMap();
                config.CreateMap<ProductFile, ProductFileModel>().ReverseMap();
                //config.CreateMap<ProductModel, Product>().ForMember(x => x.Name, mf => mf.MapFrom(s=>s.Name.ToLower()));
            });
            return mappingConfig;
        }
    }
}
