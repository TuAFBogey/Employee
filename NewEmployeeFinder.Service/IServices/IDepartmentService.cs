using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.IServices
{
    public interface IDepartmentService : IService<Department>
    {
        Task<Department> GetWithEmployeesByIdAsync(int departmentId);
    }
}
