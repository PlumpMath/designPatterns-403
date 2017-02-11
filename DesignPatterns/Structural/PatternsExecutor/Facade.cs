using System;
using DesignPatterns.Structural.Facade;
using DesignPatterns.PatternsType;

namespace DesignPatterns.Structural.PatternsExecutor
{
    public class Facade : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("FACADE PATTERN:{0}Provide a unified interface to a set of interfaces in a subsystem. {0}Façade defines a higher-level interface that makes the subsystem easier to use.", Environment.NewLine);
        }

        public void Execute()
        {
            MortgageFacade mortage = new MortgageFacade();

            Customer c = new Customer("Tomek");

            mortage.IsEligible(c, 2000);
        }

        public void Message(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine("[Enter]");
            Console.ReadLine();
        }
    }
}
