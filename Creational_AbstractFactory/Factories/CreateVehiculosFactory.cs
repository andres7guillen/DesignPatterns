using Creational_AbstractFactory.Interfaces;
using CreationalDomain.Entities.Factories;
using CreationalDomain.Interfaces.Factories;

namespace Creational_AbstractFactory.Factories
{
    public class CreateVehiculosFactory : ICreateVehiculosFactory
    {
        public IVehiculo crearAuto(string nombre)
        {
            return new Carro(Nombre: nombre);
        }

        public IVehiculo crearMoto()
        {
            return new Moto();
        }

        public IVehiculo crearTren()
        {
            return new Tren();
        }
    }
}
