﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDomain.Entities
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Persona(string nombre, int edad, string direccion, string telefono, string email)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }
    }
}
