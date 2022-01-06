using NewEmployeeFinder.Data.IRepositories;
using NewEmployeeFinder.Data.IUnitOfWorks;
using NewEmployeeFinder.Entities.Entities;
using NewEmployeeFinder.Service.IServices;
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
