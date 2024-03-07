using CreationalDomain.Entities.Factories;
using CreationalDomain.Interfaces.Factories;

namespace Creational_FactoryMethod.Factories
{
    public class CarroFactory // es el patron factory method pero de la forma Simple Factory
    {
        public IVehiculo crearCarro(string nombre) 
        {
            return new Carro(Nombre: nombre);
        }
    }
}
