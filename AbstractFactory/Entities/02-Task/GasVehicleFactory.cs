using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities._02_Task
{
    public class GasVehicleFactory : VehicleFactory
    {
        public override IVehicle CreateCar()
        {
            return new GasCar();
        }

        public override IEngine CreateEngine()
        {
            return new GasEngine();
        }
    }
}
