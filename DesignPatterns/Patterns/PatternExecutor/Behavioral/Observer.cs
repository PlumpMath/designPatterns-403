using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Common.Base;
using DesignPatterns.Behavioral.Observer;

namespace DesignPatterns.Patterns.PatternExecutor.Behavioral
{
    public class Observer : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. ");
        }

        public string DescriptionPL()
        {
            return string.Empty;
        }

        public void Execute()
        {
            ConcreteProduct product = new ConcreteProduct();

            Shop shop1 = new Shop("Shop1");
            Shop shop2 = new Shop("Shop2");
            Shop shop3 = new Shop("Shop3");
            Shop shop4 = new Shop("Shop4");

            product.Attach(shop1);
            product.Attach(shop2);

            product.Attach2(shop3);
            product.Attach2(shop4);

            product.ChangePrice(4.7f);

            product.Remove2(shop3);
            product.Remove(shop2);

            product.ChangePrice(25.6f);
        }
    }
}
