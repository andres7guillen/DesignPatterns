using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities._03_Practice
{
    public class HatchBacKCar : ICar
    {
        public void ApagarCarro()
        {
            Console.WriteLine("Apagando carro Hatchback");
        }

        public void EncenderCarro()
        {
            Console.WriteLine("Encendiendo carro Hatchback");
        }
    }
}
