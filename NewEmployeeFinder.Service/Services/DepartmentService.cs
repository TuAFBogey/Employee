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
    public class DepartmentService : Service<Department>, IDepartmentService
    {
        public DepartmentService(IUnitOfWork unitOfWork, IRepository<Department> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Department> GetWithEmployeesByIdAsync(int departmentId)
        {
            return await _unitOfWork.Departments.GetWithEmployeesByIdAsync(departmentId);
        }
    }
}
