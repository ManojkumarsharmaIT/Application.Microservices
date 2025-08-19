using Application.Microservices.Services.AuthAPI.Models;

namespace Application.Microservices.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        public string GenerateToken(ApplicationUser applicationUser,IEnumerable<string> roles);

    }
}
