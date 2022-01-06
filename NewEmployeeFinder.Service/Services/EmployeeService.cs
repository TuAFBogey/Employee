using NewEmployeeFinder.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using NewEmployeeFinder.Service.DTOs;
using NewEmployeeFinder.Service.IServices;
using NewEmployeeFinder.Data.IUnitOfWorks;
using NewEmployeeFinder.Data.IRepositories;

namespace NewEmployeeFinder.Service.Services
{
    
    public class EmployeeService : Service<Employee>, IEmployeeService
    {
        private readonly IMapper _mapper;
        public EmployeeService(IUnitOfWork unitOfWork, IRepository<Employee> repository, IMapper mapper) : base(unitOfWork, repository)
        {
            _mapper = mapper;
        }

        public void DeleteByNames(EmployeeWithNames employee)
        {
            
            _unitOfWork.Employees.Remove(_mapper.Map<Employee>(employee));
        }

        public IEnumerable<EmployeeWithNames> GetAllWithNames()
        {
            var employees = _unitOfWork.Employees.GetAllWithNames().
                Select(x => new EmployeeWithNames
                {
                    EmployeeName = x.EmployeeName,
                    DepartmentName = x.Department.DepartmentName,
                    ProjectName = x.Project.ProjectName,
                    CityName = x.City.CityName
                }).ToList();

            return employees;
        }

        public IEnumerable<EmployeeWithNames> GetEmployeesByCity(string city)
        {
            return _unitOfWork.Employees.GetAllWithNames().Select(
                x => new EmployeeWithNames
                {
                    EmployeeName = x.EmployeeName,
                    DepartmentName = x.Department.DepartmentName,
                    ProjectName = x.Project.ProjectName,
                    CityName = x.City.CityName
                }).Where(x=>x.CityName == city).OrderBy(x => x.EmployeeName).ToList();
        }

        public IEnumerable<EmployeeWithNames> GetEmployeesByNames(string name)
        {
            return _unitOfWork.Employees.GetAllWithNames().Where(x => x.EmployeeName == name).Select(
                x => new EmployeeWithNames
                {
                    EmployeeName = x.EmployeeName,
                    DepartmentName = x.Department.DepartmentName,
                    ProjectName = x.Project.ProjectName,
                    CityName = x.City.CityName
                }).ToList();
        }

        public async Task<Employee> GetWithCityByIdAsync(int employeeId)
        {
            return await _unitOfWork.Employees.GetWithCityByIdAsync(employeeId);
        }

        public async Task<Employee> GetWithDepartmentByIdAsync(int employeeId)
        {
            return await _unitOfWork.Employees.GetWithDepartmentByIdAsync(employeeId);
        }

        public async Task<Employee> GetWithProjectByIdAsync(int employeeId)
        {
            return await _unitOfWork.Employees.GetWithProjectByIdAsync(employeeId);
        }


    }
}
