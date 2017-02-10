using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.PatternsExecutor
{
    public class Composite : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Compose objects into tree structures to represent part-whole hierarchies. {0}Composite lets clients treat individual objects and compositions of objects uniformly. ", Environment.NewLine);
        }

        public void Execute()
        {
            
        }
    }
}
