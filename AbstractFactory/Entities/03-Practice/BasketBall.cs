using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities._03_Practice
{
    public class BasketBall : IBall
    {
        public void Bounce()
        {
            Console.WriteLine("Basket ball is bouncing");
        }
    }
}
