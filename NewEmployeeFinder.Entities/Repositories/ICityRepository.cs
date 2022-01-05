using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Entities.Repositories
{
    public interface ICityRepository : IRepository<City>
    {
        Task<City> GetWithEmployeesByIdAsync(int cityId);
    }
}
