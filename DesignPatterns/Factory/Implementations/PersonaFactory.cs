using DesignPatterns.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Implementations
{
    public class PersonaFactory : IPersonaFactory
    {
        public DesignPatterns.Factory.Entities.Persona CrearPersona(string nombre, string apellido, int edad, string direccion, string telefono)
        {
            return new DesignPatterns.Factory.Entities.Persona
            {
                Nombre = nombre,
                Apellido = apellido,
                Edad = edad,
                Direccion = direccion,
                Telefono = telefono
            };
        }
    }
}
