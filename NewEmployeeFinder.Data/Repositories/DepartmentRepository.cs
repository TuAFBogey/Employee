using Microsoft.EntityFrameworkCore;
using NewEmployeeFinder.Entities.Entities;
using NewEmployeeFinder.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Data.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public DepartmentRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Department> GetWithEmployeesByIdAsync(int departmentId)
        {
            return await _appDbContext.Departments.Include(x => x.Employees).SingleOrDefaultAsync(x => x.Id == departmentId);
        }
    }
}
