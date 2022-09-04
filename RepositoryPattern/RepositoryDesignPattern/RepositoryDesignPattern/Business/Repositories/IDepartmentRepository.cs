using RepositoryDesignPattern.Business.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDesignPattern.Business.Repositories
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Department GetDepartmentNameByID(int id);
    }
}
