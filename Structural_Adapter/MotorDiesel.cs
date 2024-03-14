using StructuralDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Adapter
{
    public class MotorDiesel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Motor de diesel acelerando.");
        }

        public override void Apagar()
        {
            Console.WriteLine("Motor de diesel apagando.");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Motor de diesel arrancando.");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Motor de diesel, tanqueando con diesel.");
        }
    }
}
