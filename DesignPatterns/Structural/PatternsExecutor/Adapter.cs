using System;
using DesignPatterns.Structural.Adapter;

namespace DesignPatterns.Structural.PatternsExecutor
{
    public class Adapter : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Convert the interface of a class into another interface clients expect. {0}Adapter lets classes work together that couldn't otherwise {0}because of incompatible interfaces. ", Environment.NewLine);
        }

        public void Execute()
        {
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
        }

    }
}
