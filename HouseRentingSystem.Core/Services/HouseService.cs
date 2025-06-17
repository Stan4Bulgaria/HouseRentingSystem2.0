using HouseRentingSystem2._0.Core.Contracts.House;
using HouseRentingSystem2._0.Core.Models.House;
using HouseRentingSystem2._0.Infrastructure.Common;
using HouseRentingSystem2._0.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class HouseService : IHouseService
    {
        private readonly IRepository repository;
        public HouseService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync()
        {
            return await repository
                .AllReadOnly<House>()
                .OrderByDescending(h => h.Id)
                .Take(3)
                .Select(h => new HouseIndexServiceModel()
                {
                    Id = h.Id,
                    ImageUrl = h.ImageUrl,
                    Title = h.Title,

                }).ToListAsync();

        }
        public async Task<IEnumerable<HouseCategoryServiceModel>> AllCategoriesAsync()
        {
            return await repository
                .AllReadOnly<Category>()
                .Select(c => new HouseCategoryServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToListAsync();
        }

        public async Task<bool> CategoryExistsAsync(int id)
        {
            return await repository
                .AllReadOnly<Category>()
                .AnyAsync(c => c.Id == id);
        }

        public async Task<int> CreateAsync(HouseFormModel model, int? agentId)
        {
          
             
           await repository.AddAsync(new House()
           {

               Title = model.Title,
               Address = model.Address,
               Description = model.Description,
               ImageUrl = model.ImageUrl,
               PricePerMonth = model.PricePerMonth,
               CategoryId = model.CategoryId,
               AgentId = (int)agentId
           });

            return await repository.SaveChangesAsync();

        }
        //public async Task<IEnumerable<AllHousesQueryModel>> All()
        //{

        //}
    }
}
