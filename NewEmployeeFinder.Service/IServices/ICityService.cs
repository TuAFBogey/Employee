using NewEmployeeFinder.Entities.Entities;
using NewEmployeeFinder.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.IServices
{
    public interface ICityService : IService<City>
    {
        Task<City> GetWithEmployeesByIdAsync(int cityId);
    }
}
