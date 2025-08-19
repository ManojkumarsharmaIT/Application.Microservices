using Application.Microservices.Services.CouponAPI.Models;
using Application.Microservices.Services.CouponAPI.Models.Dto;
using AutoMapper;

namespace Application.Microservices.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
