using System;
using DesignPatterns.Creational.PatternsExecutors;


namespace DesignPatterns.PatternsType
{
    public class CreationalType : PatternsTypeBase
    {
        protected override void DrawList()
        {
            Console.WriteLine("[1]. Builder");
            Console.WriteLine("[2]. Prototype");
            Console.WriteLine("[3]. Abstarct factory");
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
                    _pattern = new BuilderExecutor();
                    break;
                case 2:
                    _pattern = new PrototypeExecutor();
                    break;
                case 3:
                    _pattern = new AbstractFactoryExecutor();
                    break;
                default:
                    break;
            }
            return _pattern;
        }
    }
}
