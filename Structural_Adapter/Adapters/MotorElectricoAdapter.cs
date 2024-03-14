using StructuralDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Adapter.Adapters
{
    /// <summary>
    /// mi clase Adapter hereda de mi TARGET que en este caso es la clase Motor, 
    /// luego crea una instancia del Adaptee que en esta caso es MotorElectrico
    /// y en los metodos implmentados del Target llamo a los metodos del Adaptee.
    /// </summary>
    public class MotorElectricoAdapter : Motor
    {
        MotorElectrico motorElect = new MotorElectrico();
        public override void Acelerar()
        {
            motorElect.Avanzar();
        }

        public override void Apagar()
        {
            motorElect.Desactivar();
        }

        public override void Arrancar()
        {
            motorElect.Encender();
        }

        public override void CargarCombustible()
        {
            motorElect.RecargarBateria();
        }
    }
}
