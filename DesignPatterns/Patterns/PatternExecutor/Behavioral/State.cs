
using DesignPatterns.Common.Base;


namespace DesignPatterns.Patterns.PatternExecutor.Behavioral
{
    public class State : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Allow an object to alter its behavior when its internal state changes. The object will appear to change its class. ");
        }

        public string DescriptionPL()
        {
            return string.Format("Wzorzec projektowy, który umożliwia zmianę zachowania obiektu poprzez zmianę jego stanu wewnętrznego. Innymi słowy – uzależnia sposób działania obiektu od stanu w jakim się aktualnie znajduje.");
        }

        public void Execute()
        {
            
        }
    }
}
