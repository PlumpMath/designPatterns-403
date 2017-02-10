using System;
using DesignPatterns.Creational.PatternsExecutors;
using DesignPatterns.Helpers;
using System.Runtime.Caching;
using System.Collections.Generic;

namespace DesignPatterns.PatternsType
{
    public class CreationalType : PatternsTypeBase
    {
        private const string ASSEMBLY_NAME = "DesignPatterns.Creational.PatternsExecutors";

        protected override void DrawList()
        {
            MenuBuilder menu = new MenuBuilder();

            ObjectCache cache = MemoryCache.Default;
            IDictionary<int,string> menuCache = cache[ASSEMBLY_NAME] as IDictionary<int, string>;

            if (menuCache != null)
            {
                IdsAndNamesOfClasses = menuCache;
            }
            else
            {
                IdsAndNamesOfClasses = menu.BuildMenu<IPatternExecutor>(PatternsType.PatternTypeEnum.Creational);
                cache[ASSEMBLY_NAME] = IdsAndNamesOfClasses;
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
