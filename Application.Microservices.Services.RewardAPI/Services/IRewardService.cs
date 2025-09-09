using Application.Microservices.Services.RewardAPI.Message;

namespace Application.Microservices.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
