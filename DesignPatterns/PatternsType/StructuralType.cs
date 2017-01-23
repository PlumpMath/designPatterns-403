using System;


namespace DesignPatterns.PatternsType
{
    public class StructuralType : PatternsTypeBase
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
