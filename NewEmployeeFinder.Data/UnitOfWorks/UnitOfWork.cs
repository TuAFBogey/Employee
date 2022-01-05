using NewEmployeeFinder.Core.UnitOfWorks;
using NewEmployeeFinder.Data.Repositories;
using NewEmployeeFinder.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private EmployeeRepository _employeeRepository;

        private DepartmentRepository _departmentRepository;

        private ProjectRepository _projectRepository;

        private CityRepository _cityRepository;
        public IEmployeeRepository Employees => _employeeRepository = _employeeRepository ?? new EmployeeRepository(_context);

        public IDepartmentRepository Departments => _departmentRepository = _departmentRepository ?? new DepartmentRepository(_context);

        public IProjectRepository Projects => _projectRepository = _projectRepository ?? new ProjectRepository(_context);

        public ICityRepository Cities => _cityRepository = _cityRepository ?? new CityRepository(_context);

        public UnitOfWork(AppDbContext _appDbContext)
        {
            _context = _appDbContext;
        }

        public void Commit() //savechange
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync() //savechangeasync
        {
            await _context.SaveChangesAsync();
        }
    }
}
