using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.Entities
{
    public class PersonaSingleton
    {
        private static Persona instancia = null;

        private PersonaSingleton() { }

        public static Persona GetInstance()
        {
            if (instancia == null)
            {
                instancia = new Persona();
            }
            return instancia;
        }
    }
}
