using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities._01_Tutorial
{
    public class Beer : IDrink
    {
        public void Pour()
        {
            Console.WriteLine("Sirviendo un vaso de cerveza");
        }
    }
}
