using HouseRentingSystem2._0.Core.Models.House;
using HouseRentingSystem2._0.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem2._0.Core.Contracts.House
{

    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses();
    }
}
