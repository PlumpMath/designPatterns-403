using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Shop : IObserver
    {
        private string _name;
        private float _price;

        public Shop(string name)
        {
            _name = name;
        }

        public void Update(float price)
        {
            _price = price;
            Console.WriteLine("Product {0} has new price {1}", _name, _price);
        }
    }
}
