using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities._02_Task
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Arrancando un motor electrico");
        }
    }
}
