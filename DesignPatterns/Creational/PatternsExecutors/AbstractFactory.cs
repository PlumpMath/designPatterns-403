using System;
using DesignPatterns.PatternsType;
using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns.Creational.PatternsExecutors
{
    public class AbstractFactory : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Provide an interface for creating families of related {0}or dependent objects without specifying their concrete classes. ", Environment.NewLine);
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
