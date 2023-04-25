using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class PersonaBuilder
    {
        private Persona _persona = new Persona();

        public PersonaBuilder withNombre(string nombre) 
        { 
            _persona.Nombre = nombre;
            return this;
        }

        public PersonaBuilder withEdad(int edad) 
        { 
            _persona.Edad = edad;
            return this;
        }

        public PersonaBuilder withDireccion(string direccion) 
        { 
            _persona.Direccion = direccion;
            return this;
        }

        public PersonaBuilder withEmail(string email) 
        { 
            _persona.Email = email;
            return this;
        }

        public PersonaBuilder withTelefono(string telefono) 
        { 
            _persona.Telefono = telefono;
            return this;
        }

        public Persona Build() 
        { 
            return _persona;
        }


    }
}
