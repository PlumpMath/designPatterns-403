using DesignPatterns.Common.Base;
using DesignPatterns.Common.Helpers;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.PatternsType
{
    public class Behevioral : PatternsTypeBase
    {
        private const string ASSEMBLY_NAME = "DesignPatterns.Patterns.PatternExecutor.Behavioral";

        protected override void DrawList()
        {
            MenuBuilder menu = new MenuBuilder();
            IDictionary<int, string> menuCache = LocalCache.Instance.Get<IDictionary<int, string>>(ASSEMBLY_NAME);

            if (menuCache != null)
            {
                IdsAndNamesOfClasses = menuCache;
            }
            else
            {
                IdsAndNamesOfClasses = menu.BuildMenu<IPatternExecutor>(PatternTypeEnum.Behavioral);
                LocalCache.Instance.Add<IDictionary<int, string>>(IdsAndNamesOfClasses, ASSEMBLY_NAME);
            }

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
                TryExecutePattern(Choose, ASSEMBLY_NAME);
            }
            while (Choose.ToUpper() != BackChar);

            ClearConsole();
        }

    }
}
