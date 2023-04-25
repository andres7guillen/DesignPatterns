using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory.Entities;

namespace DesignPatterns.Factory.Interfaces
{
    public interface IPersonaFactory
    {
        DesignPatterns.Factory.Entities.Persona CrearPersona(string nombre, string apellido, int edad, string direccion, string telefono);
    }
}
