using Structural_Bridge.Interfaces.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge.Classes.Autos
{
    public class Auto
    {
        public string Marca { get; set; }
        public short Modelo { get; set; }
        public string Color { get; set; }
        public ICaja Caja { get; set; }
        public Auto(string marca, short modelo, string color, ICaja caja)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Caja = caja;
        }

        public void CambiarMarcha(byte marcha) 
        {
            Caja.CambiarMarcha(marcha);
        }

    }
}
