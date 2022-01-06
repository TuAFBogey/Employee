using NewEmployeeFinder.Data.IRepositories;
using NewEmployeeFinder.Data.IUnitOfWorks;
using NewEmployeeFinder.Entities.Entities;
using NewEmployeeFinder.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.Services
{
    public class ProjectService : Service<Project>, IProjectService
    {
        public ProjectService(IUnitOfWork unitOfWork, IRepository<Project> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Project> GetWithEmployeesByIdAsync(int projectId)
        {
            return await _unitOfWork.Projects.GetWithEmployeesByIdAsync(projectId);
        }
    }
}
