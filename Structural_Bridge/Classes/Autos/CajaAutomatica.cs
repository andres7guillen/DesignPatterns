using Structural_Bridge.Interfaces.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge.Classes.Autos
{
    public class CajaAutomatica : ICaja
    {
        public void CambiarMarcha(int marcha)
        {
            Console.WriteLine($"Nuevo cambio a: {marcha} de forma automatica");
        }
    }
}
