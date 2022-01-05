using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Entities.Repositories
{
    public interface IEmployeeRepository:IRepository<Employee>
    {
        Task<Employee> GetWithDepartmentByIdAsync(int employeeId);
        Task<Employee> GetWithProjectByIdAsync(int employeeId);
        Task<Employee> GetWithCityByIdAsync(int employeeId);
        IQueryable<Employee> GetAllWithNames();
    }
}
