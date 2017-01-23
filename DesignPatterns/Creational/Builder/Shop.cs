using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Shop
    {
        public void Construct(VehicleBuilderBase vehicleBuilder)
        {
            vehicleBuilder.BuildDoors();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildWheels();
        }
    }
}
