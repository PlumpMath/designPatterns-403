using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.PatternsExecutors
{
    public class AbstractFactoryExecutor : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Provide an interface for creating families of related {0}or dependent objects without specifying their concrete classes. ", Environment.NewLine);
        }

        public void Execute()
        {
            
        }

        public void Message(string message)
        {
            
        }
    }
}
