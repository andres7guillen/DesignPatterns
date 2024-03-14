using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge.Interfaces.HotDogs
{
    public interface IHotDogMachine
    {
        public void startHotDogMachine();
        public string getHotDog();
    }
}
