using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities._01_Tutorial
{
    public class ChickenRestaurant : Restaurant
    {
        protected override IBurger createBurger()
        {
            return new ChickenBurger();
        }
        
    }
}
