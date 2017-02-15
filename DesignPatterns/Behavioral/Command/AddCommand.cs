using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class AddCommand : CommandBase
    {
        public AddCommand(IReciever reciever) : base(reciever) { }

        public override int Execute()
        {
            _reciever.SetAction(ActionList.ADD);
            return _reciever.GetResult();
        }
    }
}
