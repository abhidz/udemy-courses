using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.Business.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDesignPattern.Data
{
    public class LocalContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

    }
}
