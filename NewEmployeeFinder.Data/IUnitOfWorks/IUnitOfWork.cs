using NewEmployeeFinder.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Data.IUnitOfWorks
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employees { get; }

        IDepartmentRepository Departments { get; }

        IProjectRepository Projects { get; }

        ICityRepository Cities { get; }

        Task CommitAsync();

        void Commit();
    }
}
