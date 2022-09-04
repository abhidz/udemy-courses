using RepositoryDesignPattern.Business.Domain;
using RepositoryDesignPattern.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDesignPattern.Data
{
    public class UnitofWork : IUnitofWork
    {
        private readonly LocalContext _localContext;

        public UnitofWork(LocalContext localContext)
        {
            this._localContext = localContext;
        }
        public IEmployeRepository EmployeRepository { get { return new EmployeeRepository(this._localContext); } }

        public IDepartmentRepository DepartmentRepository { get { return new DepartmentRepository(this._localContext); } }

        public void Dispose()
        {
            _localContext.Dispose();
        }

        public void Save()
        {
            _localContext.SaveChanges();
        }
    }
}
