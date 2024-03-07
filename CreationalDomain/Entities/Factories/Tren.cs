using CreationalDomain.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDomain.Entities.Factories
{
    public class Tren : IVehiculo
    {
        public void Arrancar()
        {
            Console.WriteLine("El tren arrancó");
        }

        public void Encender()
        {
            Console.WriteLine("El tren encendió");
        }

        public void Frenar()
        {
            Console.WriteLine("El tren frenó");
        }
    }
}
