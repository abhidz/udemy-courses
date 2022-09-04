using RepositoryDesignPattern.Data;
using System;

namespace RepositoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitofWork = new UnitofWork(new LocalContext()))
            {
                unitofWork.EmployeRepository.GetNameByID(1);
                unitofWork.DepartmentRepository.GetDepartmentNameByID(1);
            }
            Console.ReadLine();
        }
    }
}
