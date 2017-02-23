using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Common.Base;
using DesignPatterns.Behavioral.Template_Method;

namespace DesignPatterns.Patterns.PatternExecutor.Behavioral
{
    public class Template_Method : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure. ");
        }

        public string DescriptionPL()
        {
            return string.Format("ego zadaniem jest zdefiniowanie metody, będącej szkieletem algorytmu. Algorytm ten może być następnie dokładnie definiowany w klasach pochodnych. Niezmienna część algorytmu zostaje opisana w metodzie szablonowej, której klient nie może nadpisać.");
        }

        public void Execute()
        {
            DataAccessObject data = new Categories();
            data.Run();

            data = new Product();
            data.Run();

        }
    }
}
