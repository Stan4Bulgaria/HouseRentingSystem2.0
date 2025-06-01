using HouseRentingSystem2._0.Core.Contracts.Agent;
using HouseRentingSystem2._0.Infrastructure.Common;
using HouseRentingSystem2._0.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class AgentService : IAgentService
    {
        private readonly IRepository repository;
        public AgentService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<bool> ExistsByIdAsync(string userId)
        {
            var result = await repository
                .AllReadOnly<Agent>()
                .AnyAsync(x => x.UserId == userId);

            return result;
        }
        public async Task CreateAsync(string userId, string phoneNumber)
        {
            var agent = new Agent
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            };
            await repository.AddAsync(agent);
            await repository.SaveChangesAsync();

            ;
        }

        public async Task<bool> UserHasRentsAsync(string userId)
        {
            var result = await repository
                .AllReadOnly<House>()
                .AnyAsync(h => h.RenterId == userId);

            return result;

        }

        public async Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber)
        {
            var result = await repository
                .AllReadOnly<Agent>()
                .AnyAsync(x => x.PhoneNumber == phoneNumber);

            return result;
        }
    }
}
