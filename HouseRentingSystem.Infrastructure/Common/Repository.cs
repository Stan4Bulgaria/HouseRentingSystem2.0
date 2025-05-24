using HouseRentingSystem2._0.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem2._0.Infrastructure.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext context;
        public Repository(HouseRentingSystemDbContext _context)
        {
           context = _context;
        }
        private DbSet<T> DbSet<T>() where T : class
        {
            return  context.Set<T>();
        }
        IQueryable<T> IRepository.All<T>()  where T: class
        {
            return DbSet<T>().AsQueryable();  
        }

        IQueryable<T> IRepository.AllReadOnly<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }

        
    }
}
