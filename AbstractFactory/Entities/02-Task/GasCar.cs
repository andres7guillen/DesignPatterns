using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities._02_Task
{
    public class GasCar : IVehicle
    {
        public void Assemble()
        {
            Console.WriteLine("Ensamblando un carro a gas");
        }
    }
}
