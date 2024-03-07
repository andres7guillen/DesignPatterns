using CreationalDomain.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDomain.Entities.Factories
{
    public class Moto : IVehiculo
    {
        public void Arrancar()
        {
            Console.WriteLine("La moto arrancó");
        }

        public void Encender()
        {
            Console.WriteLine("La moto encendió");
        }

        public void Frenar()
        {
            Console.WriteLine("La moto frenó");
        }
    }
}
