using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Vehicle
    {
        private string _vehicle;
        private Dictionary<Parts, string> _parts = new Dictionary<Parts, string>();

        public Vehicle(string vehicle)
        {
            _vehicle = vehicle;
        }

        public string this[Parts key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine("Vehicle type: {0}", _vehicle);
            Console.WriteLine("Frame: {0}", _parts[Parts.frame]);
            Console.WriteLine("Engine: {0}", _parts[Parts.engine]);
            Console.WriteLine("Wheels: {0}", _parts[Parts.wheels]);
            Console.WriteLine("Doors: {0}", _parts[Parts.doors]);
        }

    }

    public enum Parts
    {
        frame,
        engine,
        wheels,
        doors
    }
}
