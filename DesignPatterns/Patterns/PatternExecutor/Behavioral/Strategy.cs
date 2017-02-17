using System;
using DesignPatterns.Common.Base;
using DesignPatterns.Behavioral.Strategy;

namespace DesignPatterns.Patterns.PatternExecutor.Behavioral
{
    public class Strategy : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Define a family of algorithms, encapsulate each one, and make them interchangeable. {0}Strategy lets the algorithm vary independently from clients that use it. ", Environment.NewLine);
        }

        public string DescriptionPL()
        {
            return string.Format("Czynnościowy wzorzec projektowy, który definiuje rodzinę wymiennych algorytmów i {0}kapsułkuje je w postaci klas. Umożliwia wymienne stosowanie każdego z nich {0}w trakcie działania aplikacji niezależnie od korzystających z nich klientów.", Environment.NewLine);
        }

        public void Execute()
        {
            SortedList list = new SortedList();

            list.Add("Tomek");
            list.Add("Janek");
            list.Add("Marek");

            list.SetSortStrategy(new QuickSort());

            list.Sort();

            list.SetSortStrategy(new MergeSort());

            list.Sort();

            list.SetSortStrategy(new ShellSort());

            list.Sort();
        }
    }
}
