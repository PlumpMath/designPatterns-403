using DesignPatterns.Patterns.PatternsType;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Common.Base
{
    public abstract class PatternsTypeBase
    {

        private const string BACK = "B";
        private string _choose;
        private IDictionary<int, string> _idAndNamesOfClasses;

        public IDictionary<int, string> IdsAndNamesOfClasses
        {
            get { return _idAndNamesOfClasses;}
            set { _idAndNamesOfClasses = value;}
        }

        public string Choose
        {
            get { return _choose; }
            set { _choose = value; }
        }

        public string BackChar
        {
            get { return BACK; }
        }

        protected void ClearConsole()
        {
            Console.Clear();
        }

        protected virtual void DrawList()
        {
            Console.WriteLine("[B]. Back");
        }

        protected void TryExecutePattern(string choose, string assembly)
        {
            int _number;

            if (Int32.TryParse(choose, out _number))
            {
                ExecuteBuilder(PatternExecutorFactory(_number, assembly));
            }
            else
                Console.WriteLine("Wrong format");
        }

        private void ExecuteBuilder(IPatternExecutor pattern)
        {
            if (pattern != null)
            {
                Console.WriteLine(pattern.Description());
                Console.WriteLine();
                Console.WriteLine(pattern.DescriptionPL());
                pattern.Execute();
                Console.WriteLine();
            }
        }

        //Factory for specific executer
        protected virtual IPatternExecutor PatternExecutorFactory(int index, string assembly)
        {
            IPatternExecutor _pattern = null;
            if (IdsAndNamesOfClasses.Count >= index)
            {
                Type type = Type.GetType(string.Format("{0}.{1}", assembly, IdsAndNamesOfClasses[index]));
                object t = Activator.CreateInstance(type);
                if (t != null)
                    _pattern = (IPatternExecutor)t;
            }
            return _pattern;
        }

        public abstract void Execute();


    }
}
