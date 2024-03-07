using CreationalDomain.Entities.Factories;
using CreationalDomain.Interfaces.Factories;

namespace Creational_FactoryMethod.Factories
{
    public class VehiculoFactory // Usando un metodo se crean los objetos, en este caso depende del parametro enviado
    {
        public IVehiculo crearVehiculo(string tipo)
        { 
            switch(tipo) 
            {
                case "Carro": return new Carro("Mazda");
                case "Moto": return new Moto();
                case "Tren": return new Tren();
                default: return null;
            }            
        }
    }
}
