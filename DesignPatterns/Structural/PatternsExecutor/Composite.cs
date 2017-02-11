using System;
using DesignPatterns.PatternsType;

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
