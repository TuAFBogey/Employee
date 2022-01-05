using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.DTOs
{
    public class ProjectWithEmployeeDto:ProjectDto
    {
        public ICollection<EmployeeDto> Employees { get; set; }
    }
}
