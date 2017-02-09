using DesignPatterns.Structural.PatternsExecutor;
using System;


namespace DesignPatterns.PatternsType
{
    public class StructuralType : PatternsTypeBase
    {
        protected override void DrawList()
        {
            Console.WriteLine("[1]. Decorator");
            Console.WriteLine("[2]. Facade");
            base.DrawList();
        }

        public override void Execute()
        {
            ClearConsole();

            do
            {
                DrawList();
                Choose = Console.ReadLine();
                TryExecutePattern(Choose);
            }
            while (Choose.ToUpper() != BackChar);

            ClearConsole();
        }

        protected override IPatternExecutor PatternExecutorFactory(int index)
        {
            IPatternExecutor _pattern = null;
            switch (index)
            {
                case 1:
                    _pattern = new DecoratorExecutor();
                    break;
                case 2:
                    _pattern = new FacadeExecutor();
                    break;
                default:
                    break;
            }
            return _pattern;
        }
    }
}
