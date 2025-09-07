using Application.Microservices.Services.EmailAPI.Models.Dto;

namespace Application.Microservices.Services.EmailAPI.Services
{
    public interface IEmailService
    {

        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        //Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
