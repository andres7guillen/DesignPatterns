using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Builder.Entities;
using DesignPatterns.Builder.Interfaces;

namespace DesignPatterns.Builder
{
    public class PersonaBuilder : IPersonaBuilder
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _direccion;
        private string _telefono;

        public void withNombre(string nombre)
        {
            _nombre = nombre;
        }

        public void withApellido(string apellido)
        {
            _apellido = apellido;
        }

        public void withEdad(int edad)
        {
            _edad = edad;
        }

        public void withDireccion(string direccion)
        {
            _direccion = direccion;
        }

        public void withTelefono(string telefono)
        {
            _telefono = telefono;
        }

        public DesignPatterns.Builder.Entities.Persona ObtenerPersona()
        {
            return new DesignPatterns.Builder.Entities.Persona(_nombre, _apellido, _edad, _direccion, _telefono);
        }
    }

    // Clase Director que utiliza la clase Builder para constuir la Persona paso a paso
    public class PersonaDirector
    {
        private readonly IPersonaBuilder _personaBuilder;

        public PersonaDirector(IPersonaBuilder personaBuilder)
        {
            _personaBuilder = personaBuilder;
        }

        public void construirPersona()
        {
            _personaBuilder.withNombre("Andrés");
            _personaBuilder.withApellido("Guillén");
            _personaBuilder.withEdad(30);
            _personaBuilder.withDireccion("Av siempre viva 123");
            _personaBuilder.withTelefono("3213391383");
        }
    }
}
