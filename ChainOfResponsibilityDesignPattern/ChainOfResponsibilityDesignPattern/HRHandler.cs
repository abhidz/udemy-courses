using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class HRHandler : Employee
    {
        public override void ApplyLeave(string employeeName, int noOfDays)
        {
            int NumberOfDaysHRCanApprove = 30;

            if(noOfDays <= NumberOfDaysHRCanApprove)
            {
                ApproveLeave(employeeName, noOfDays);
            }
            else
            {
                Console.WriteLine("Leave application suspended, Please contact HR");
            }
        }

        private void ApproveLeave(string employeeName, int noOfDays)
        {
            Console.WriteLine("Leaves approved by HR for" + employeeName + "for" + noOfDays + "days");
        }
    }
}
