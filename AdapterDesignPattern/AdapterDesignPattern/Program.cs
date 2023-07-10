using AdapterDesignPattern.Example2;
using System;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //IBird bird = new Sparrow();
            //bird.fly();
            //bird.makeSound();

            //IToyDuck toyDuck = new PlasticToyDuck();
            //toyDuck.squeak();

            //BirdAdaptor birdAdaptor = new BirdAdaptor(bird);
            //birdAdaptor.squeak();

            // EmployeeSalary
            ITarget target = new EmployeeAdapter();
            string[,] empArray = new string[,]
            {
               { "Abhishek", "10000" },
               { "Riya", "1000000" }
            };
            target.ProcessCompanySalary(empArray);
            Console.ReadLine();
        }
    }
}
