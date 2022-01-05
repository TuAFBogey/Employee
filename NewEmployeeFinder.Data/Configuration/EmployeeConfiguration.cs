using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewEmployeeFinder.Data.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id); ///Id primary key olsun
            builder.Property(x => x.Id).UseIdentityColumn(); ///1er 1er artsın
            builder.Property(x => x.EmployeeName).IsRequired().HasMaxLength(50); /// Name gerekli olsun ve maks 50 karakter.

            builder.ToTable("Employees");
        }
    }
}
