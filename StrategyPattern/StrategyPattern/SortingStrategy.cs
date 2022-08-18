using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class SortingStrategy
    {
        public abstract void Sort(List<int> list);
    }
}
