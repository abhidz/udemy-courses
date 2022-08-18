using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new BubbleSort());
            context.Add(23);
            context.Add(2);
            context.Add(4);
            context.ShowSortedList();
            Console.ReadLine();
        }
    }
}
