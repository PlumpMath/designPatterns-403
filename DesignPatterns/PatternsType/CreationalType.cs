using System;
using DesignPatterns.Creational.PatternsExecutors;
using DesignPatterns.Helpers;

namespace DesignPatterns.PatternsType
{
    public class CreationalType : PatternsTypeBase
    {
        protected override void DrawList()
        {
            MenuBuilder menu = new MenuBuilder();

            var listOfMenu = menu.BuildMenu<IPatternExecutor>(PatternsType.PatternTypeEnum.Creational);

            foreach (var item in listOfMenu)
                Console.WriteLine("[{0}]. {1}.", item.Key, item.Value);

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
