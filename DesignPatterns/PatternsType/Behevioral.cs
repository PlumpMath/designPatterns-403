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
        protected override void DrawList()
        {
            MenuBuilder menu = new MenuBuilder();

            var listOfMenu = menu.BuildMenu<IPatternExecutor>(PatternsType.PatternTypeEnum.Behavioral);

            foreach (var item in listOfMenu)
                Console.WriteLine("[{0}]. {1}.", item.Key, item.Value);

            base.DrawList();
        }

        public override void Execute()
        {
            
        }

        protected override IPatternExecutor PatternExecutorFactory(int index)
        {
            return null;
        }
    }
}
