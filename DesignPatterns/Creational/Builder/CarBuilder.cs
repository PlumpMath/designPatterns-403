using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class CarBuilder : VehicleBuilderBase
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        public override void BuildDoors()
        {
            vehicle[Parts.doors] = "Car door";
        }

        public override void BuildEngine()
        {
            vehicle[Parts.engine] = "Car engine";
        }

        public override void BuildFrame()
        {
            vehicle[Parts.frame] = "Car frame";
        }

        public override void BuildWheels()
        {
            vehicle[Parts.wheels] = "Car wheels";
        }
    }
}
