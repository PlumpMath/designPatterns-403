using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class PrototypeExecutor : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("PROTOTYPE PATTERN{0}Specify the kind of objects to create using a prototypical {0}instance, and create new objects by copying this prototype.", Environment.NewLine);
        }

        public void Execute()
        {

        }
    }
}
