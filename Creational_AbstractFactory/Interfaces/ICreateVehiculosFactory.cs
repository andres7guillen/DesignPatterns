using CreationalDomain.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_AbstractFactory.Interfaces
{
    internal interface ICreateVehiculosFactory
    {
        IVehiculo crearAuto(string name);
        IVehiculo crearMoto();
        IVehiculo crearTren();
    }
}
