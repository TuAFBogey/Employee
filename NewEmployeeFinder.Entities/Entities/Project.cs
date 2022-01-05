using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace NewEmployeeFinder.Entities.Entities
{
    public class Project
    {
        public Project()
        {
            Employees = new Collection<Employee>(); ///
        }
        public int Id { get; set; }

        public string ProjectName { get; set;}

        public bool IsDeleted { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
