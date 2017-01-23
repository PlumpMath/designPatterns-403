using System;
using DesignPatterns.Creational.Builder;

namespace DesignPatterns
{
    public class PatternSelector
    {
        private int _patternIndex;       
        private string _choose;
        private const string BACK = "B";

        public PatternSelector (int index)
        {
            _patternIndex = index;
        }

        public void SelectPatterns()
        {
            switch (_patternIndex)
            {
                case 1:
                    CreationalPatterns();
                    break;
                case 2:
                    StructuralPatterns();
                    break;
                case 3:
                    BehavioralPatterns();
                    break;
                default:
                    break;
            }
        }
        private void CreationalPatterns()
        {
            ClearConsole();

            do
            {
                Console.WriteLine("[1]. Builder");
                Console.WriteLine("[B]. Back");

                _choose = Console.ReadLine();
                TryExecutePattern(_choose);
            }
            while (_choose.ToUpper() != BACK);

            ClearConsole();            
        }
        private void StructuralPatterns()
        {
            ClearConsole();
        }
        private void BehavioralPatterns()
        {
            ClearConsole();
        }

        private void ClearConsole()
        {
            Console.Clear();
        }

        private void TryExecutePattern(string choose)
        {
            int _number;

            if (Int32.TryParse(choose, out _number))
            {
                ExecuteBuilder(PatternExecutorFactory(_number));
            }
            else
                Console.WriteLine("Wrong format");
        }

        private void ExecuteBuilder(IPatternExecutor pattern)
        {
            if (pattern != null)
            {
                Console.WriteLine(pattern.Description());
                pattern.Execute();
                Console.WriteLine();
            }
                
        }

        private IPatternExecutor PatternExecutorFactory(int index)
        {
            IPatternExecutor _pattern = null;
            switch (index)
            {
                case 1:
                    _pattern = new BuilderExecutor();
                    break;
                default:
                    break;
            }
            return _pattern;
        }

    }
}
