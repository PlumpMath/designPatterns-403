using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class Multiply : CommandBase
    {
        public Multiply(IReciever reciever) : base(reciever) { }

        public override int Execute()
        {
            _reciever.SetAction(ActionList.MUL);
            return _reciever.GetResult();
        }
    }
}
