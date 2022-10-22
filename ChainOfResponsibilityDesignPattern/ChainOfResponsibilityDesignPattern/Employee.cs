using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public abstract class Employee
    {
        protected Employee _supervisor;

        public void SetNextSupervisor(Employee supervisor)
        {
            _supervisor= supervisor;
        }

        public abstract void ApplyLeave(string employeeName, int noOfDays);

    }
}
