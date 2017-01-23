using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Color : ColorPrototype
    {
        private int _red, _green, _blue;

        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0,3},{1,3},{2,3}", _red, _green, _blue);
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
