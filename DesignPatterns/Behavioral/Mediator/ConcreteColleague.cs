using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteColleague<T> : IColleague<T>
    {
        private string _name;

        public ConcreteColleague(string name)
        {
            _name = name;
        }

        void IColleague<T>.ReceiveMessage(T message)
        {
            Console.WriteLine("{0}{1}{2}", this._name, "received", message.ToString());
        }

        void IColleague<T>.SendMessage(IMediator<T> mediator, T message)
        {
            mediator.DistributeMessage(this, message);
        }
    }
}
