using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.PatternsExecutor
{
    public class Bridge : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Decouple an abstraction from its implementation {0}so that the two can vary independently. ", Environment.NewLine);
        }

        public void Execute()
        {
            
        }
    }
}
