using Microsoft.EntityFrameworkCore;
using NewEmployeeFinder.Entities.Entities;
using NewEmployeeFinder.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewEmployeeFinder.Entities.Repositories;

namespace NewEmployeeFinder.Data.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public CityRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<City> GetWithEmployeesByIdAsync(int cityId)
        {
            return await _appDbContext.Cities.Include(x => x.Employees).SingleOrDefaultAsync(x => x.Id == cityId);
        }
    }
}
