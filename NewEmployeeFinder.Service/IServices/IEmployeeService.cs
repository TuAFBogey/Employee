using NewEmployeeFinder.Entities.Entities;
using NewEmployeeFinder.Service.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.IServices
{
    public interface IEmployeeService : IService<Employee>
    {
        Task<Employee> GetWithDepartmentByIdAsync(int employeeId);

        Task<Employee> GetWithProjectByIdAsync(int employeeId);

        Task<Employee> GetWithCityByIdAsync(int employeeId);

        IEnumerable<EmployeeWithNames> GetAllWithNames();

        IEnumerable<EmployeeWithNames> GetEmployeesByNames(string name);

        IEnumerable<EmployeeWithNames> GetEmployeesByCity(string city);

        void DeleteByNames(EmployeeWithNames employee);
    }
}
