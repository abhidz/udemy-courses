using RepositoryDesignPattern.Business.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDesignPattern.Business.Repositories
{
    public interface IEmployeRepository : IRepository<Employee>
    {
        Employee GetNameByID(int id);
    }
}
