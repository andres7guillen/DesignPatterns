using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities._02_Task
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateCar();
        public abstract IEngine CreateEngine();
    }
}
