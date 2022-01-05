using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.DTOs
{
    public class EmployeeWithDepartmentDto:EmployeeDto
    {
        public DepartmentDto Department { get; set; }
    }
}
