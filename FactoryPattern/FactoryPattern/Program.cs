using System;
using static System.Console;
namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new VehicleFactory();
            WriteLine(factory.GetNumberOfTyres.GetNumberOfTyres("FourWheeler"));
            WriteLine(factory.GetNumberOfWindows.GetNumberOfWindows("TwoWheeler"));
            ReadLine();
        }
    }
}
