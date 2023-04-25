using DesignPatterns.Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Implementation
{
    public class PersonaPrototype : IPersona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public PersonaPrototype(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public IPersona Clonar()
        {
            return new PersonaPrototype(Nombre, Edad);
        }

        public string ObtenerInformacion()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}";
        }
    }
}
