using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Interfaces
{
    public interface IPersonaBuilder
    {
        void withNombre(string nombre);
        void withApellido(string apellido);
        void withEdad(int edad);
        void withDireccion(string direccion);
        void withTelefono(string telefono);
        DesignPatterns.Builder.Entities.Persona ObtenerPersona();
    }
}
