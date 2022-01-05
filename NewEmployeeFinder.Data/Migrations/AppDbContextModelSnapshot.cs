﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewEmployeeFinder.Data;

namespace NewEmployeeFinder.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewEmployeeFinder.Entities.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Eskişehir",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Ankara",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CityName = "İstanbul",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("NewEmployeeFinder.Entities.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentName = "Software",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            DepartmentName = "Embedded Software",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            DepartmentName = "R&D",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            DepartmentName = "Human Resources",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("NewEmployeeFinder.Entities.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            DepartmentId = 1,
                            EmployeeName = "Uğur",
                            IsDeleted = false,
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            DepartmentId = 1,
                            EmployeeName = "Furkan",
                            IsDeleted = false,
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            DepartmentId = 2,
                            EmployeeName = "Mertkan",
                            IsDeleted = false,
                            ProjectId = 4
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            DepartmentId = 2,
                            EmployeeName = "Doğukan",
                            IsDeleted = false,
                            ProjectId = 3
                        },
                        new
                        {
                            Id = 5,
                            CityId = 3,
                            DepartmentId = 4,
                            EmployeeName = "Resul",
                            IsDeleted = false,
                            ProjectId = 6
                        },
                        new
                        {
                            Id = 6,
                            CityId = 3,
                            DepartmentId = 3,
                            EmployeeName = "Cihat",
                            IsDeleted = false,
                            ProjectId = 5
                        });
                });

            modelBuilder.Entity("NewEmployeeFinder.Entities.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            ProjectName = "dotNet Core Web API"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            ProjectName = "Unity Game"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            ProjectName = "Biometric Attendance System"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            ProjectName = "Wireless Metal Detector Robot"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            ProjectName = "R&D"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            ProjectName = "HR"
                        });
                });

            modelBuilder.Entity("NewEmployeeFinder.Entities.Entities.Employee", b =>
                {
                    b.HasOne("NewEmployeeFinder.Entities.Entities.City", "City")
                        .WithMany("Employees")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewEmployeeFinder.Entities.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewEmployeeFinder.Entities.Entities.Project", "Project")
                        .WithMany("Employees")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Department");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("NewEmployeeFinder.Entities.Entities.City", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("NewEmployeeFinder.Entities.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("NewEmployeeFinder.Entities.Entities.Project", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
