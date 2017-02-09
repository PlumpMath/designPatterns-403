using DesignPatterns.Helpers;
using DesignPatterns.Structural.PatternsExecutor;
using System;
using System.Reflection;

namespace DesignPatterns.PatternsType
{
    public class StructuralType : PatternsTypeBase
    {
        protected override void DrawList()
        {
            MenuBuilder menu = new MenuBuilder();

            IdsAndNamesOfClasses = menu.BuildMenu<IPatternExecutor>(PatternsType.PatternTypeEnum.Structural);

            foreach (var item in IdsAndNamesOfClasses)
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
