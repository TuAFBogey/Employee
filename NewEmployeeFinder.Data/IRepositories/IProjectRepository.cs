using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Data.IRepositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<Project> GetWithEmployeesByIdAsync(int projectId);
    }
}
