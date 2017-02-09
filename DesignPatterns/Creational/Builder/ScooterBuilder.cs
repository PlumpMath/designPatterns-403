using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class ScooterBuilder : VehicleBuilderBase
    {
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Scooter");
        }

        public override void BuildDoors()
        {
            vehicle[Parts.doors] = "Scooter door";
        }

        public override void BuildEngine()
        {
            vehicle[Parts.engine] = "Scooter engine";
        }

        public override void BuildFrame()
        {
            vehicle[Parts.frame] = "Scooter frame";
        }

        public override void BuildWheels()
        {
            vehicle[Parts.wheels] = "Scooter wheels";
        }
    }
}
