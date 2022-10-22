using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class ManagerHandler : Employee
    {
        public override void ApplyLeave(string employeeName, int noOfDays)
        {
            int NumberOfDaysManagerCanApprove = 20;

            if(noOfDays <= NumberOfDaysManagerCanApprove)
            {
                ApproveLeave(employeeName, noOfDays);
            }
            else
            {
                _supervisor.ApplyLeave(employeeName, noOfDays);
            }
        }

        private void ApproveLeave(string employeeName, int noOfDays)
        {
            Console.WriteLine("Leaves approved by manager for" + employeeName + "for" + noOfDays + "days");
        }
    }
}
