using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.Business.Domain;
using RepositoryDesignPattern.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RepositoryDesignPattern.Data
{
    public class EmployeeRepository : Repository<Employee>, IEmployeRepository
    {
        public EmployeeRepository(LocalContext localContext) : base(localContext)
        {

        }

        public Employee GetNameByID(int id)
        {
            return LocalContext.Employees.SingleOrDefault(i => i.ID == id);
        }
        public LocalContext LocalContext
        {
            get { return new LocalContext(); }
        }
    }
}
