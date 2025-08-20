using Application.Microservices.Services.ProductAPI.Models;
using Application.Microservices.Services.ProductAPI.Models.Dto;
using AutoMapper;

namespace Application.Microservices.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
