using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.DTOs
{
    public class EmployeeWithNames
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
        public string ProjectName { get; set; }
        public string CityName { get; set; }
    }
}
