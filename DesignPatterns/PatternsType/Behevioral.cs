using DesignPatterns.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsType
{
    public class Behevioral : PatternsTypeBase
    {
        private const string ASSEMBLY_NAME = "DesignPatterns.Behavioral.PatternsExecutor";

        protected override void DrawList()
        {
            MenuBuilder menu = new MenuBuilder();

            IdsAndNamesOfClasses = menu.BuildMenu<IPatternExecutor>(PatternsType.PatternTypeEnum.Behavioral);

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
