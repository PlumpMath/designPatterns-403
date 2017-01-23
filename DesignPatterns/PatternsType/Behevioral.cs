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
            base.DrawList();
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }

        protected override IPatternExecutor PatternExecutorFactory(int index)
        {
            throw new NotImplementedException();
        }
    }
}
