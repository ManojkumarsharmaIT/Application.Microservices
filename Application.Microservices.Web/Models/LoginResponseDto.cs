using Application.Microservices.Services.AuthAPI.Models.Dto;

namespace Application.Microservices.Web.Models
{
    public class LoginResponseDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
    }
}
