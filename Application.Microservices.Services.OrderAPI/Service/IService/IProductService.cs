
using Application.Microservices.Services.OrderAPI.Models.Dto;

namespace Application.Microservices.Services.OrderAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();

    }
}
