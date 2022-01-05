using System;
using System.Collections.Generic;
using System.Text;

namespace NewEmployeeFinder.Core.Services
{
    public interface IUserService
    {
        bool CheckUser(string username, string password);
    }
}
