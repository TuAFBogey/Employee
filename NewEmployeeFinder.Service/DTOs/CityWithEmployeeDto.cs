using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.DTOs
{
    public class CityWithEmployeeDto:CityDto
    {
        public ICollection<EmployeeDto> Employees { get; set; }
    }
}
