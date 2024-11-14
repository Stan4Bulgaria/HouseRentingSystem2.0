using HouseRentingSystem2._0.Infrastructure.Data.Models;
using HouseRentingSystem2._0.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem2._0.Infrastructure.Data
{
    public class HouseRentingSystemDbContext : IdentityDbContext
    {
        public DbSet<House> Houses { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Category> Categories { get; set; }

        public HouseRentingSystemDbContext(DbContextOptions<HouseRentingSystemDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CategorieConfiguration());
            builder.ApplyConfiguration(new HouseConfiguration());
            builder.ApplyConfiguration(new AgentConfiguration());

            base.OnModelCreating(builder);
        }
      
    }
}
