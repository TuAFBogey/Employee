using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        public int ProjectId { get; set; }
        public int CityId { get; set; }
    }
}
