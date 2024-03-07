using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDomain.Entities.Singleton
{
    public class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        private static Persona _instance;

        private Persona() { }

        public static Persona getPersona()
        {
            if (_instance == null)
            {
                _instance = new Persona();
            }
            return _instance;
        }
    }
}
