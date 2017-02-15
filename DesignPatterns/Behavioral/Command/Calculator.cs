using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class Calculator : IReciever
    {
        private int _x, _y;
        private ActionList _action;

        public Calculator(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int GetResult()
        {
            int result;
            if (_action == ActionList.ADD)
                result = _x + _y;
            else if (_action == ActionList.MUL)
                result = _x * _y;
            else
                result = _x - _y;

            return result;
        }

        public void SetAction(ActionList action)
        {
            _action = action;
        }
    }
}
