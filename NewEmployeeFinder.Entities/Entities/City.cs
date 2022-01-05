using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace NewEmployeeFinder.Entities.Entities
{
    public class City
    {
        public City()
        {
            Employees = new Collection<Employee>(); ///
        }
        public int Id { get; set; }

        public string CityName { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
