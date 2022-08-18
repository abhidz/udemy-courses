using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class MergeSort : SortingStrategy
    {
        public override void Sort(List<int> list)
        {
            list.Sort();
            Console.WriteLine("merge list sorted" + list[0]);
        }
    }
}
