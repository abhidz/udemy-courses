using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class BubbleSort : SortingStrategy
    {
        public override void Sort(List<int> list)
        {
            list.Sort();
            Console.WriteLine("bubble list sorted");
        }
    }
}
