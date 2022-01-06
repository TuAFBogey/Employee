using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Data.IRepositories
{
    public interface IDepartmentRepository:IRepository<Department>
    {
        Task<Department> GetWithEmployeesByIdAsync(int departmentId);
    }
}
