using DesignPatterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Implementations
{
    public class PersonaAdapter : IPersonaTarget
    {
        private DesignPatterns.Adapter.Entities.Persona persona;

        public PersonaAdapter(DesignPatterns.Adapter.Entities.Persona persona)
        {
            this.persona = persona;
        }

        public string ObtenerNombreCompleto()
        {
            return $"{persona.Nombre} {persona.Apellido}";
        }

        public int ObtenerEdad()
        {
            return persona.Edad;
        }
    }
}
