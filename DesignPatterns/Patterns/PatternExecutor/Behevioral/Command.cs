using System;
using DesignPatterns.Common.Base;

namespace DesignPatterns.Patterns.PatternExecutor.Behavioral
{
    public class Command : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Encapsulate a request as an object, {0}thereby letting you parameterize clients with different requests, {0}queue or log requests, and support undoable operations. ", Environment.NewLine);
        }

        public void Execute()
        {
            
        }
    }
}
