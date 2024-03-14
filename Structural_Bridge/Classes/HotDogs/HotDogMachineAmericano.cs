using Structural_Bridge.Interfaces.HotDogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge.Classes.HotDogs
{
    public class HotDogMachineAmericano : IHotDogMachine
    {
        public string getHotDog()
        {
            return "Hot dog Americano";
        }

        public void startHotDogMachine()
        {
            Console.WriteLine("Starting machine");
        }
    }
}
