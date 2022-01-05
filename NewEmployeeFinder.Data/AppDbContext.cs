using Microsoft.EntityFrameworkCore;
using NewEmployeeFinder.Data.Configuration;
using NewEmployeeFinder.Data.Seeds;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewEmployeeFinder.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///modelBuilder.Entity<Employee>().HasKey(x => x.Id);  
            ///Bunları burda da tanımlayabilirdik ancak Best Practise açısından 
            ///DbContext sınıfı ne kadar sade kalırsa o kadar daha iyi olur.

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());

            modelBuilder.ApplyConfiguration(new EmployeeSeed(new int[] { 1, 2, 3, 4, 5, 6 }));
            modelBuilder.ApplyConfiguration(new DepartmentSeed(new int[] { 1, 2, 3, 4 }));
            modelBuilder.ApplyConfiguration(new ProjectSeed(new int[] { 1, 2, 3, 4, 5, 6 }));
            modelBuilder.ApplyConfiguration(new CitySeed(new int[] { 1, 2, 3 }));
        }
    }
}
