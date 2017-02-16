using System;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Common.Base;

namespace DesignPatterns.Patterns.PatternExecutor.Creational
{
    public class AbstractFactory : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Provide an interface for creating families of related {0}or dependent objects without specifying their concrete classes. ", Environment.NewLine);
        }

        public string DescriptionPL()
        {
            return string.Empty;
        }

        public void Execute()
        {
            ContinentFactory afrika = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(afrika);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }

        public void Message(string message)
        {
            
        }
    }
}
