using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
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


        public IEnumerable<EmployeeWithNames> GetAllWithNames()
        {
            var employees = _unitOfWork.Employees.GetAllWithNames().
                Select(x => new EmployeeWithNames
                {
                    Id = x.Id,
                    EmployeeName = x.EmployeeName,
                    DepartmentName = x.Department.DepartmentName,
                    ProjectName = x.Project.ProjectName,
                    CityName = x.City.CityName
                }).ToList().Distinct();

            return employees;
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
