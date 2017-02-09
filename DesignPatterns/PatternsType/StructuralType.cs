using DesignPatterns.Helpers;
using DesignPatterns.Structural.PatternsExecutor;
using System;
using System.Reflection;

namespace DesignPatterns.PatternsType
{
    public class StructuralType : PatternsTypeBase
    {
        private const string ASSEMBLY_NAME = "DesignPatterns.Structural.PatternsExecutor";

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
                TryExecutePattern(Choose, ASSEMBLY_NAME);
            }
            while (Choose.ToUpper() != BackChar);

            ClearConsole();
        }
    }
}
