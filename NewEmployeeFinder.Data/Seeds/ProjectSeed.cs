using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewEmployeeFinder.Data.Seeds
{
    public class ProjectSeed : IEntityTypeConfiguration<Project>
    {
        private readonly int[] _ids;
        public ProjectSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(
                new Project { Id = _ids[0], ProjectName = "dotNet Core Web API" },
                new Project { Id = _ids[1], ProjectName = "Unity Game" },
                new Project { Id = _ids[2], ProjectName = "Biometric Attendance System" },
                new Project { Id = _ids[3], ProjectName = "Wireless Metal Detector Robot" },
                new Project { Id = _ids[4], ProjectName = "R&D" },
                new Project { Id = _ids[5], ProjectName = "HR" }
                );
        }
    }
}
