using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities._03_Practice
{
    public class SedanCarFactory : CarFactory
    {
        protected override ICar CreateCar()
        {
            return new SedanCar();
        }
    }
}
