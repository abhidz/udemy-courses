using RepositoryDesignPattern.Business.Domain;
using RepositoryDesignPattern.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryDesignPattern.Data
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(LocalContext localContext):base(localContext)
        {

        }
        public Department GetDepartmentNameByID(int id)
        {
            return LocalContext.Departments.SingleOrDefault(i => i.DeptID == id);
        }

        public LocalContext LocalContext
        {
            get {return Context as LocalContext; }
        }

        public void  Insert(Department department)
        {
            LocalContext.AddRange(department);
        }
    }
}
