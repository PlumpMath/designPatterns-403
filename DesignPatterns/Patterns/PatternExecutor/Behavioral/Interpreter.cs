using System;
using System.Collections.Generic;
using DesignPatterns.Common.Base;
using DesignPatterns.Behavioral.Interpreter;

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
            string token = "+ * 10 2 * 5 3";
            List<string> tokenList = new List<string>(token.Split(' '));

            IExpression expression = new TokenReader().ReadToken(tokenList);
            Console.WriteLine(expression.Interpret());
        }
    }
}
