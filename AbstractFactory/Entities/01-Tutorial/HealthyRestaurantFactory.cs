using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities._01_Tutorial
{
    public class HealthyRestaurantFactory : RestaurantFactory
    {
        public override IBurger createBurger()
        {
            return new ChickenBurger();
        }

        public override IDrink createDrink()
        {
            return new Water();
        }
    }
}
