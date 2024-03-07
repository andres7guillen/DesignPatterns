using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDomain.Entities.Builder
{
    public class TipoCuenta
    {
        public string Descripcion { get; set; }
        public TipoCuenta(string descripcion)
        {
            Descripcion = descripcion;
        }
    }
}
