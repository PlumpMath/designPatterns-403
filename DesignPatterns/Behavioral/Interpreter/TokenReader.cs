using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class TokenReader
    {
        public IExpression ReadToken(List<string> tokenList)
        {
            return ReadNextToken(tokenList);
        }

        private IExpression ReadNextToken(List<string> tokenList)
        {
            int i;
            if (int.TryParse(tokenList.First(), out i))
            {
                tokenList.RemoveAt(0);
                return new NumberExpression(i);
            }
            else
                return ReadNonTerminal(tokenList);
        }

        private IExpression ReadNonTerminal(List<string> tokenList)
        {
            string token = tokenList.First();
            tokenList.RemoveAt(0);
            IExpression leftExpression = ReadNextToken(tokenList);
            IExpression rightExprssion = ReadNextToken(tokenList);

            if (token == "+")
                return new AddExpression(leftExpression, rightExprssion);
            else if (token == "-")
                return new SubtractExpression(leftExpression, rightExprssion);
            else if (token == "*")
                return new MultiplyExpression(leftExpression, rightExprssion);
            else
                return null;
        }

    }
}
