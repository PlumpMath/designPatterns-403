using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class SortedList
    {
        private SortStrategy _strategy;
        private List<string> _list = new List<string>();

        public void SetSortStrategy(SortStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _strategy.Sort(_list);

            foreach(var l in _list)
            {
                Console.WriteLine(l);
            }
        }

    }
}
