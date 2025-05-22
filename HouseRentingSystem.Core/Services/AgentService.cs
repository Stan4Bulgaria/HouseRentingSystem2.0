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

        public async Task<bool> ExistsById(string userId)
        {
            var result = await repository.AllReadOnly<Agent>().AnyAsync(x => x.UserId == userId);

            return result;
        }
    }
}
