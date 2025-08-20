using Application.Microservices.Web.Models;

namespace Application.Microservices.Web.Service.IService
{
    public interface IProductService
    {
        Task<ResponseDto?> GetAllProductsAsync();
        Task<ResponseDto?> GetProductByIdAsync(int id);
        Task<ResponseDto?> CreateProductsAsync(ProductDto couponDto);
        Task<ResponseDto?> UpdateProductsAsync(ProductDto couponDto);
        Task<ResponseDto?> DeleteProductsAsync(int id);
    }
}
