using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Entities
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Persona(string nombre, string apellido, int edad, string direccion, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
