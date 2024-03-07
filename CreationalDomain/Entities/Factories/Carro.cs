using CreationalDomain.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDomain.Entities.Factories
{
    public class Carro : IVehiculo
    {
        private string Nombre;
        public Carro(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public void Arrancar()
        {
            Console.WriteLine($"El carro {Nombre} arrancó");
        }

        public void Encender()
        {
            Console.WriteLine($"El carro {Nombre} encendió");
        }

        public void Frenar()
        {
            Console.WriteLine($"El carro {Nombre} frenó");
        }
    }
}
