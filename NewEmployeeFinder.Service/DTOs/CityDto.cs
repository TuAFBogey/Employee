using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.DTOs
{
    public class CityDto
    {
        public int Id { get; set; }
        public string CityName { get; set; }
    }
}
