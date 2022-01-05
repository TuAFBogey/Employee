using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewEmployeeFinder.Data.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.Id); ///Id primary key olsun
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.DepartmentName).IsRequired().HasMaxLength(100);

            builder.ToTable("Departments");
        }
    }
}
