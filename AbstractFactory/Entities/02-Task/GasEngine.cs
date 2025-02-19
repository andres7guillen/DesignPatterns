using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities._02_Task
{
    public class GasEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Arrancando motor a gas");
        }
    }
}
