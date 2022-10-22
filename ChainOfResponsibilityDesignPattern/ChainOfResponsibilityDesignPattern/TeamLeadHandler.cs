using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class TeamLeadHandler : Employee
    {
        public override void ApplyLeave(string employeeName, int noOfDays)
        {
            int NumberOfDaysTLCanApprove = 10;

            if(noOfDays <= NumberOfDaysTLCanApprove)
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
            Console.WriteLine("Leaves approved by TL for" + employeeName + "for" + noOfDays + "days");
        }
    }
}
