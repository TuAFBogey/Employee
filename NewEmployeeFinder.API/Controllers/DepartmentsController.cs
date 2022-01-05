using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewEmployeeFinder.Service.DTOs;
using NewEmployeeFinder.Core.Services;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace NewEmployeeFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;
        public DepartmentsController(IDepartmentService departmentService, IMapper mapper)
        {
            _departmentService = departmentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var departments = await _departmentService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<DepartmentDto>>(departments));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var department = await _departmentService.GetByIdAsync(id);
            return Ok(_mapper.Map<DepartmentDto>(department));
        }

        [HttpGet("{id}/employees")]
        public async Task<IActionResult> GetWithEmployeesById(int id)
        {
            var department = await _departmentService.GetWithEmployeesByIdAsync(id);
            return Ok(_mapper.Map<DepartmentWithEmployeeDto>(department));
        }

        [HttpPost]
        public async Task<IActionResult> Save(DepartmentDto departmentDto)
        {
            var newDepartment = await _departmentService.AddAsync(_mapper.Map<Department>(departmentDto));
            return Created(string.Empty, _mapper.Map<DepartmentDto>(newDepartment));
        }

        [HttpPut]
        public IActionResult Update(DepartmentDto departmentDto)
        {
            var department = _departmentService.Update(_mapper.Map<Department>(departmentDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var department = await _departmentService.GetByIdAsync(id);
            _departmentService.Remove(department);
            return NoContent();
        }
    }
}
