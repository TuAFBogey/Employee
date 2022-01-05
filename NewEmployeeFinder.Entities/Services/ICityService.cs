using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Core.Services
{
    public interface ICityService : IService<City>
    {
        Task<City> GetWithEmployeesByIdAsync(int cityId);
    }
}
