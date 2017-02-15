using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class ConcreteProduct : SubjectBase
    {
        public void ChangePrice(float price)
        {
            Notify(price);
        }
    }
}
