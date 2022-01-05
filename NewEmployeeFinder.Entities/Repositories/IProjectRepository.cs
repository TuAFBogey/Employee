using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Entities.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<Project> GetWithEmployeesByIdAsync(int projectId);
    }
}
