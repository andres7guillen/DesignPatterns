using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities._03_Practice
{
    public class SedanCar : ICar
    {
        public void ApagarCarro()
        {
            Console.WriteLine("Apagando un carro sedan");
        }

        public void EncenderCarro()
        {
            Console.WriteLine("Encendiendo un carro sedan");
        }
    }
}
