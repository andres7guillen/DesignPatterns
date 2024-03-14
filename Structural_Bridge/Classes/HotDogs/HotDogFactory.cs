using Structural_Bridge.Interfaces.HotDogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge.Classes.HotDogs
{
    public abstract class HotDogFactory
    {
        protected IHotDogMachine hotDogMachine;
        public HotDogFactory(IHotDogMachine hdm)
        {
            hotDogMachine = hdm;
        }

        public abstract void PrepareHotDog();
    }
}
