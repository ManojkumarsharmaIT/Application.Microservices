using Application.Microservices.Services.ShoppingCartAPI.Models;
using Application.Microservices.Services.ShoppingCartAPI.Models.Dto;
using AutoMapper;

namespace Application.Microservices.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
