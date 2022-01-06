using AutoMapper;
using NewEmployeeFinder.Service.DTOs;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Department, DepartmentDto>();
            CreateMap<DepartmentDto, Department>();

            CreateMap<Employee, EmployeeDto>().ReverseMap();

            CreateMap<Department, DepartmentWithEmployeeDto>();
            CreateMap<DepartmentWithEmployeeDto, Department>();

            CreateMap<Project, ProjectDto>();
            CreateMap<ProjectDto, Project>();

            CreateMap<City, CityDto>();
            CreateMap<CityDto, City>();

            CreateMap<Employee, EmployeeWithDepartmentDto>();
            CreateMap<EmployeeWithDepartmentDto, Employee>();

            CreateMap<Project, ProjectWithEmployeeDto>();
            CreateMap<ProjectWithEmployeeDto, Project>();

            CreateMap<Employee, EmployeeWithProjectDto>();
            CreateMap<EmployeeWithProjectDto, Employee>();

            CreateMap<City, CityWithEmployeeDto>();
            CreateMap<CityWithEmployeeDto, City>();

            CreateMap<Employee, EmployeeWithCityDto>();
            CreateMap<EmployeeWithCityDto, Employee>();

            CreateMap<Employee, EmployeeWithNames>().ReverseMap();
           
        }
    }
}
