using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AdapterDesignPattern.Example2
{
    public class EmployeeSalary
    {
        public EmployeeSalary(string name, double salary)
        {
            Name = name;
            this.Salary = salary;
        }

        public string Name { get; set; }

        public double Salary { get; set; }
    }

    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<EmployeeSalary> salaryList)
        {
            foreach (var item in salaryList)
            {
                Console.WriteLine($"{item.Salary} is credited to {item.Name}");
            }
        }
    }

    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }

    public class EmployeeAdapter : ITarget
    {
        private readonly ThirdPartyBillingSystem billingSystem = new ThirdPartyBillingSystem();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string Name = null;
            string Salary = null;
            List<EmployeeSalary> listEmployee = new List<EmployeeSalary>();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Name = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Salary = employeesArray[i, j];
                    }
                }
                listEmployee.Add(new EmployeeSalary(Name, Convert.ToDouble(Salary)));
            }
             billingSystem.ProcessSalary(listEmployee);
        }
    }

}
