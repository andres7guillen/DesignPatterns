using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Adapter
{
    public class MotorElectrico
    {
        private bool cargaElectrica;
        public string Encender() 
        {
            if (cargaElectrica)
            {
                return "Encendiendo motor electrico";
            }
            else 
            {
                return "Motor no se puede encender, no hay carga electrica";
            }
        }

        public string Desactivar() 
        {
            return "Motor electrico ha sido desactivado";
        }

        public string Avanzar() 
        {
            if (cargaElectrica)
            {
                return "Motor electrico avanza";
            }
            else 
            {
                return "motor electrico con bateria insuficiente, no puede avanzar.";
            }
        }

        public void RecargarBateria() 
        {
            Console.WriteLine("La bateria se está cargando. \n\n");
            cargaElectrica = true;
            Console.WriteLine("La bateria del motor electrico ha sido cargada.");
        }
    }
}
