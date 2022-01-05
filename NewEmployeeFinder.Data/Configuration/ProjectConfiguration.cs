using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewEmployeeFinder.Data.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ProjectName).IsRequired().HasMaxLength(100);

            builder.ToTable("Projects");
        }
    }
}
