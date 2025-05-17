using HouseRentingSystem2._0.Core.Contracts.House;
using HouseRentingSystem2._0.Core.Models.House;
using HouseRentingSystem2._0.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem2._0.Core.Services.House
{
    public class HouseService : IHouseService
    {
        private readonly IRepository repository;
        public HouseService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses()
        {
            return await repository
                .AllReadOnly<Infrastructure.Data.Models.House>()
                .OrderByDescending(h => h.Id)
                .Take(3)
                .Select(h => new HouseIndexServiceModel()
                {
                    Id = h.Id,
                    ImageUrl = h.ImageUrl,
                    Title = h.Title,
                }).ToListAsync();
               
        }
    }
}
