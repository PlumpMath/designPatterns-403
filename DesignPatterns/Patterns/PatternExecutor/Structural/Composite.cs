using System;
using DesignPatterns.Common.Base;

namespace DesignPatterns.Patterns.PatternExecutor.Structural
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
