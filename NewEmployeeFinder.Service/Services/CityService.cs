using NewEmployeeFinder.Core.Services;
using NewEmployeeFinder.Core.UnitOfWorks;
using NewEmployeeFinder.Entities.Entities;
using NewEmployeeFinder.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.Services
{
    public class CityService : Service<City>, ICityService
    {
        public CityService(IUnitOfWork unitOfWork, IRepository<City> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<City> GetWithEmployeesByIdAsync(int cityId)
        {
            return await _unitOfWork.Cities.GetWithEmployeesByIdAsync(cityId);
        }

    }
}
