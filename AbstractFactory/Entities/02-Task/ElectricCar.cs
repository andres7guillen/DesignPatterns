using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities._02_Task
{
    public class ElectricCar : IVehicle
    {
        public void Assemble()
        {
            Console.WriteLine("Ensamblando un carro electrico");
        }
    }
}
