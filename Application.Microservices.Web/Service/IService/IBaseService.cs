
using Application.Microservices.Web.Models;

namespace Application.Microservices.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto request, bool withBearer = true);
    }
}
