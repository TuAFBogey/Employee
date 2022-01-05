using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewEmployeeFinder.Data.Seeds
{
    public class EmployeeSeed:IEntityTypeConfiguration<Employee>
    {
        private readonly int[] _ids;
        public EmployeeSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee { Id = 1, EmployeeName = "Uğur", DepartmentId = _ids[0], ProjectId = _ids[0], CityId = _ids[0] },
                new Employee { Id = 2, EmployeeName = "Furkan", DepartmentId = _ids[0], ProjectId = _ids[1], CityId = _ids[0] },
                new Employee { Id = 3, EmployeeName = "Mertkan", DepartmentId = _ids[1], ProjectId = _ids[3], CityId = _ids[1] },
                new Employee { Id = 4, EmployeeName = "Doğukan", DepartmentId = _ids[1], ProjectId = _ids[2], CityId = _ids[1] },
                new Employee { Id = 5, EmployeeName = "Resul", DepartmentId = _ids[3], ProjectId = _ids[5], CityId = _ids[2] },
                new Employee { Id = 6, EmployeeName = "Cihat", DepartmentId = _ids[2], ProjectId = _ids[4], CityId = _ids[2] }
                );
        }
    }
}
