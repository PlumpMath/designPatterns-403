using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Common.Base;

namespace DesignPatterns.Patterns.PatternExecutor.Behavioral
{
    public class Interpreter : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language. ");
        }

        public string DescriptionPL()
        {
            return string.Format("Czynnościowy wzorzec projektowy, którego celem jest zdefiniowanie opisu gramatyki pewnego języka interpretowalnego, a także stworzenie dla niej interpretera, dzięki któremu będzie możliwe rozwiązanie opisanego problemu.");
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
