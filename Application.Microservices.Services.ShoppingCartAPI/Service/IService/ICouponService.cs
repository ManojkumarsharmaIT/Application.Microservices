using Application.Microservices.Services.ShoppingCartAPI.Models.Dto;

namespace Application.Microservices.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
