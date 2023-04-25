using DesignPatternsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Interfaces
{
    public interface IPersonaAbstractFactory
    {
        Persona CrearPersona(string nombre, int edad, string direccion, string telefono, string email);
    }
}
