using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class SubtractExpression : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public SubtractExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public int Interpret()
        {
            return leftExpression.Interpret() - rightExpression.Interpret();
        }
    }
}
