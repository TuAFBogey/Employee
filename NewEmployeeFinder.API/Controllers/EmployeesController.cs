using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewEmployeeFinder.Entities.Entities;
using NewEmployeeFinder.Service.DTOs;
using NewEmployeeFinder.Service.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewEmployeeFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeesController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {            
            var employees = await _employeeService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<EmployeeDto>>(employees));
        }

        [HttpGet("employee")]
        public IActionResult GetAllEmployeeWithNames()
        {
            var employee = _employeeService.GetAllWithNames();
            return Ok(_mapper.Map<IEnumerable<EmployeeWithNames>>(employee));
        }

        [HttpGet("byName")]
        public IActionResult GetAllEmployeeByName(string name)
        {
            var employee = _employeeService.GetEmployeesByNames(name);
            return Ok(_mapper.Map<IEnumerable<EmployeeWithNames>>(employee));
        }

        [HttpGet("byCity")]
        public IActionResult GetAllEmployeeByCity(string city)
        {
            var employee = _employeeService.GetEmployeesByCity(city);
            return Ok(_mapper.Map<IEnumerable<EmployeeWithNames>>(employee));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            return Ok(_mapper.Map<EmployeeDto>(employee));
        }

        [HttpGet("{id}/department")]
        public async Task<IActionResult> GetWithDepartmentsById(int id)
        {
            var employee = await _employeeService.GetWithDepartmentByIdAsync(id);
            return Ok(_mapper.Map<EmployeeWithDepartmentDto>(employee));
        }

        [HttpGet("{id}/project")]
        public async Task<IActionResult> GetWithProjectsById(int id)
        {
            var employee = await _employeeService.GetWithProjectByIdAsync(id);
            return Ok(_mapper.Map<EmployeeWithProjectDto>(employee));
        }

        [HttpGet("{id}/city")]
        public async Task<IActionResult> GetWithCitiesById(int id)
        {
            var employee = await _employeeService.GetWithCityByIdAsync(id);
            return Ok(_mapper.Map<EmployeeWithCityDto>(employee));
        }

        [HttpPost]
        public async Task<IActionResult> Save(EmployeeDto employeeDto)
        {
            var newEmployee = await _employeeService.AddAsync(_mapper.Map<Employee>(employeeDto));
            return Created(string.Empty, _mapper.Map<EmployeeDto>(newEmployee));
        }

        [HttpPut]
        public IActionResult Update(EmployeeDto employeeDto)
        {
            var employee = _employeeService.Update(_mapper.Map<Employee>(employeeDto));
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            _employeeService.Remove(employee);
            return NoContent();
        }

        [HttpPost("range")]
        public async Task<IActionResult> AddRange(IEnumerable<EmployeeDto> employeeDto)
        {
           var newEmployees = await _employeeService.AddRangeAsync(_mapper.Map<IEnumerable<Employee>>(employeeDto));
           return Created(string.Empty, newEmployees);
        }
    }
}
