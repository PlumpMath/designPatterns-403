using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template_Method
{
    public class Categories : DataAccessObject
    {
        public override void Process()
        {
            Console.WriteLine("Proscess from Categories class");
        }

        public override void Select()
        {
            Console.WriteLine("Select from Categories class");
        }
    }
}
