using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities._01_Tutorial
{
    public abstract class RestaurantFactory
    {
        public abstract IBurger createBurger();
        public abstract IDrink createDrink();
    }
}
