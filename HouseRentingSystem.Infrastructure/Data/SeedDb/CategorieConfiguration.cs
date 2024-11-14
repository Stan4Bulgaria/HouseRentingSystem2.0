using HouseRentingSystem2._0.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem2._0.Infrastructure.Data.SeedDb
{
    internal class CategorieConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();
            builder.HasData(new Category[] {data.DuplexCategory,data.SingleCategory, data.CottageCategory});
        }
    }
}
