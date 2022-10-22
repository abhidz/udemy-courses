using System;

namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var TL =new TeamLeadHandler();
            var manager = new ManagerHandler();
            var HR = new HRHandler();

            TL.SetNextSupervisor(manager);
            manager.SetNextSupervisor(HR);

            TL.ApplyLeave("Abhishek", 12);
            TL.ApplyLeave("Abhishek", 2);
            TL.ApplyLeave("Abhishek", 32);
            Console.ReadLine();
        }
    }
}
