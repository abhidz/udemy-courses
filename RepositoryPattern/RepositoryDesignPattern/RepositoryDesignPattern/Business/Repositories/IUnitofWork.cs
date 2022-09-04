using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDesignPattern.Business.Repositories
{
    public interface IUnitofWork : IDisposable
    {
        void Save();

        IEmployeRepository EmployeRepository { get; }
    }
}
