using StructuralDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Adapter
{
    public class MotorCombustible : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Motor de gasolina acelerando."); 
        }

        public override void Apagar()
        {
            Console.WriteLine("Motor de gasolina apagando."); 
        }
                        
        public override void Arrancar()
        {
            Console.WriteLine("Motor de gasolina arrancando.");
        }
                        
        public override void CargarCombustible()
        {
            Console.WriteLine("Motor de gasolina, tanqueando gasolina.");
        }
    }
}
