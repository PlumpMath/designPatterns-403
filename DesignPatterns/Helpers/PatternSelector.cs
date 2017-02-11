using DesignPatterns.PatternsType;
using System;

namespace DesignPatterns.Helpers
{
    public class PatternSelector
    {
        private string _className;
        private string _assemblyName;   

        public PatternSelector (string className, string assemblyName)
        {
            _className = className;
            _assemblyName = assemblyName;
        }

        public void SelectPatterns()
        {
            PatternsTypeBase patternsType = null;
            Type type = Type.GetType(string.Format("{0}.{1}", _assemblyName, _className));
            object t = Activator.CreateInstance(type);

            if (t != null)
                patternsType = (PatternsTypeBase)t;

            patternsType?.Execute();
        }

    }
}
