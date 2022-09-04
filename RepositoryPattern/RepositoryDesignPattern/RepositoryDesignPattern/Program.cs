using RepositoryDesignPattern.Business.Domain;
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
                var department = new Department
                {
                    DeptID = 1,
                    DeptName = "Taxation"
                };
                unitofWork.DepartmentRepository.Insert(department);
                unitofWork.Save();
            }
            Console.ReadLine();
        }
    }
}
