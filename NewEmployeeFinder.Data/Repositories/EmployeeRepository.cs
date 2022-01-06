using Microsoft.EntityFrameworkCore;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using NewEmployeeFinder.Data.IRepositories;

namespace NewEmployeeFinder.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {

        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public EmployeeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Employee> GetWithCityByIdAsync(int employeeId)
        {
            return await _appDbContext.Employees.Include(x => x.City).SingleOrDefaultAsync(x => x.Id == employeeId);
        }

        public async Task<Employee> GetWithDepartmentByIdAsync(int employeeId)
        {
            return await _appDbContext.Employees.Include(x => x.Department).SingleOrDefaultAsync(x => x.Id == employeeId);
        }

        public async Task<Employee> GetWithProjectByIdAsync(int employeeId)
        {
            return await _appDbContext.Employees.Include(x => x.Project).SingleOrDefaultAsync(x => x.Id == employeeId);
        }

        public IQueryable<Employee> GetAllWithNames()
        {
            return _appDbContext.Employees.Include(d => d.Department)
                                  .Include(d=>d.Project)
                                  .Include(d=>d.City)
                                  .AsQueryable();
        }
    }
}
