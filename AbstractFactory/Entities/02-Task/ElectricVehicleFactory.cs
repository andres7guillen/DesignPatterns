using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities._02_Task
{
    public class ElectricVehicleFactory : VehicleFactory
    {
        public override IVehicle CreateCar()
        {
            return new ElectricCar();
        }

        public override IEngine CreateEngine()
        {
            return new ElectricEngine();
        }
    }
}
