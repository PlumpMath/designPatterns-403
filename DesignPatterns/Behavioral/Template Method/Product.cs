using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template_Method
{
    public class Product : DataAccessObject
    {
        public override void Process()
        {
            Console.WriteLine("Process from product");
        }

        public override void Select()
        {
            Console.WriteLine("Select from product class");
        }
    }
}
