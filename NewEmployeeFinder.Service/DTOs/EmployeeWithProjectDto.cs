using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.DTOs
{
    public class EmployeeWithProjectDto:EmployeeDto
    {
        public ProjectDto Project { get; set; }
    }
}
