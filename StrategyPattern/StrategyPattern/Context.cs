using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Context
    {
        private readonly SortingStrategy _sortingStrategy;
        private List<int> list = new List<int>();
        public Context(SortingStrategy sortingStrategy)
        {
            this._sortingStrategy = sortingStrategy;
        }
        public void Add(int num)
        {
            list.Add(num);
        }
        public void ShowSortedList()
        {
            this._sortingStrategy.Sort(list);
            foreach (var item in list)
            {
                Console.WriteLine(" " + item);
            }
        }
    }
}
