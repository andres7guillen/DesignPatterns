using Structural_Bridge.Interfaces.HotDogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge.Classes.HotDogs
{
    public class SmallHotDogFactory : HotDogFactory
    {
        public SmallHotDogFactory(IHotDogMachine hdm) : base(hdm) { }
        public override void PrepareHotDog()
        {
            Console.WriteLine("Small hot dogs.");
            hotDogMachine.startHotDogMachine();
            Console.WriteLine($"{hotDogMachine.getHotDog()}");
        }
    }
}
