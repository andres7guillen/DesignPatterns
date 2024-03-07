using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDomain.Entities.Builder
{
    public class Cuenta
    {
        public Guid Id { get; set; }
        public TipoCuenta TipoCuenta { get; set; }
        public string NumeroCuenta { get; set; } = string.Empty;
        public string BancoCuenta { get; set; } = string.Empty;
        public string Titular { get; set; } = string.Empty;

        public Cuenta(Guid id,TipoCuenta tipoCuenta, string numeroCuenta, string bancoCuenta, string titular)
        {
            Id = id;
            TipoCuenta = tipoCuenta;
            NumeroCuenta = numeroCuenta;
            BancoCuenta = bancoCuenta;
            Titular = titular;
        }
    }
}
