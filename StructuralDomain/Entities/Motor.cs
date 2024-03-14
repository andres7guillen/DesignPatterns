using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDomain.Entities
{
    public abstract class Motor
    {
        public abstract void Acelerar();
        public abstract void Apagar();
        public abstract void Arrancar();
        public abstract void CargarCombustible();
    }
}
