using System;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Common.Base;

namespace DesignPatterns.Patterns.PatternExecutor.Structural
{
    public class Adapter : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Convert the interface of a class into another interface clients expect. {0} " + 
                "Adapter lets classes work together that couldn't otherwise {0}because of incompatible interfaces. ", Environment.NewLine);
        }

        public string DescriptionPL()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            Compound water = new RichCompoundAdapter("Water");
            water.Display();

            Compound benzene = new RichCompoundAdapter("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompoundAdapter("Ethanol");
            ethanol.Display();
        }

    }
}
