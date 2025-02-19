using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities._03_Practice
{
    public class HatchBackCarFactory : CarFactory
    {
        protected override ICar CreateCar()
        {
            return new HatchBacKCar();
        }
    }
}
