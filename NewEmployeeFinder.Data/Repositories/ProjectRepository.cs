using Microsoft.EntityFrameworkCore;
using NewEmployeeFinder.Entities.Entities;
using NewEmployeeFinder.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Data.Repositories
{
    class ProjectRepository : Repository<Project>, IProjectRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public ProjectRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Project> GetWithEmployeesByIdAsync(int projectId)
        {
            return await _appDbContext.Projects.Include(x => x.Employees).SingleOrDefaultAsync(x => x.Id == projectId);
        }
    }
}
