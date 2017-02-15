using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public abstract class CommandBase
    {
        protected IReciever _reciever;

        public CommandBase(IReciever reciever)
        {
            _reciever = reciever;
        }

        public abstract int Execute();
    }
}
