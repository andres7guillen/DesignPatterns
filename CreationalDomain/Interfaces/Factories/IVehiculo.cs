using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDomain.Interfaces.Factories
{
    public interface IVehiculo
    {
        public void Encender();
        public void Arrancar();
        public void Frenar();
    }
}
