using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class SubstractCommand : CommandBase
    {
        public SubstractCommand(IReciever reciever) : base(reciever) { }

        public override int Execute()
        {
            _reciever.SetAction(ActionList.SUB);
            return _reciever.GetResult();
        }
    }
}
