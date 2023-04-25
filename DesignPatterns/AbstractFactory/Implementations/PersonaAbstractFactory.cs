using DesignPatterns.AbstractFactory.Interfaces;
using DesignPatternsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Implementations
{
    public class PersonaAbstractFactory : IPersonaAbstractFactory
    {
        public PersonaAbstractFactory()
        {
        }

        public Persona CrearPersona(string nombre, int edad, string direccion, string telefono, string email)
        {
            return new Persona(nombre: nombre, edad: edad, direccion: direccion, telefono:telefono, email: email);
        }
    }
}
