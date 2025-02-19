using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities._01_Tutorial
{
    public class BeefRestaurant : Restaurant
    {
        protected override IBurger createBurger()
        {
            return new BeefBurger();
        }
    }
}
