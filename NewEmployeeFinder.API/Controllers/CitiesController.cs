using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewEmployeeFinder.Service.DTOs;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewEmployeeFinder.Service.IServices;

namespace NewEmployeeFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;
        public CitiesController(ICityService cityService, IMapper mapper)
        {
            _cityService = cityService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cities = await _cityService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CityDto>>(cities));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var city = await _cityService.GetByIdAsync(id);
            return Ok(_mapper.Map<CityDto>(city));
        }

        [HttpGet("{id}/employees")]
        public async Task<IActionResult> GetWithCitiesById(int id)
        {
            var city = await _cityService.GetWithEmployeesByIdAsync(id);
            return Ok(_mapper.Map<CityWithEmployeeDto>(city));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CityDto cityDto)
        {
            var newCity = await _cityService.AddAsync(_mapper.Map<City>(cityDto));
            return Created(string.Empty, _mapper.Map<CityDto>(newCity));
        }

        [HttpPut]
        public IActionResult Update(CityDto cityDto)
        {
            var city = _cityService.Update(_mapper.Map<City>(cityDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var city = await _cityService.GetByIdAsync(id);
            _cityService.Remove(city);
            return NoContent();
        }
    }
}
