using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_ChainOfResponsability.Classes
{
    internal class Automovil
    {
        public string TipoCaja { get; private set; }
        public string Marca { get; private set; }
        public short Modelo { get; set; }

        private Automovil() { }
        private Automovil(string tipoCaja, string marca, short modelo)
        {
            TipoCaja = tipoCaja;
            Marca = marca;
            Modelo = modelo;
        }

        public static Automovil CrearAutomovil(string withTipoCaja, string withMarca, short withModelo) 
        {
            return new Automovil(tipoCaja: withTipoCaja, marca: withMarca, modelo: withModelo);
        }

        public override string ToString()
        {
            return $"El carro es de marca {Marca}, su caja es: {TipoCaja} y es modelo: {Modelo}";
        }

    }
}
