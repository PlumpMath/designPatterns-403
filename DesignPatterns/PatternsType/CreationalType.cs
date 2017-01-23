using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Prototype;
using System;


namespace DesignPatterns.PatternsType
{
    public class CreationalType : PatternsTypeBase
    {
        protected override void DrawList()
        {
            Console.WriteLine("[1]. Builder");
            Console.WriteLine("[2]. Prototype");
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
                default:
                    break;
            }
            return _pattern;
        }
    }
}
