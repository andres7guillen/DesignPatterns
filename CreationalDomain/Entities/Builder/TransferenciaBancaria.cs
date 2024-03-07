using CreationalDomain.Interfaces.Builder;

namespace CreationalDomain.Entities.Builder
{
    public class TransferenciaBancaria
    {
        public Guid Id { get; set; }
        public int ValorTransferencia { get; set; }
        public Cuenta CuentaOrigen { get; set; }
        public Cuenta CuentaDestino { get; set; }
        public DateTime FechaTransaccion { get; set; }

        private TransferenciaBancaria() { }

        public override string ToString()
        {
            return $"Transferencia Bancaria: \n Id={Id},\n Valor={ValorTransferencia},\n CuentaOrigen={CuentaOrigen.NumeroCuenta} - {CuentaOrigen.BancoCuenta}, CuentaDestino={CuentaDestino.NumeroCuenta}-{CuentaDestino.BancoCuenta},\n Fecha={FechaTransaccion.ToString("dd-mm-yyyy")}";
        }
        public class TransferenciaBancariaBuilder : IBuilder<TransferenciaBancaria>
        {
            private TransferenciaBancaria _transferenciaBancaria = new TransferenciaBancaria();
            public  TransferenciaBancaria build()
            {
                return _transferenciaBancaria;
            }

            public TransferenciaBancariaBuilder conId(Guid id) 
            {
                _transferenciaBancaria.Id = id;
                return this;
            }

            public TransferenciaBancariaBuilder conCuentaOrigen(Guid id, TipoCuenta tipoCuenta, string numeroCuenta, string bancoCuenta, string titular) 
            { 
                _transferenciaBancaria.CuentaOrigen = new Cuenta(id: id, tipoCuenta: tipoCuenta, numeroCuenta: numeroCuenta, bancoCuenta: bancoCuenta, titular: titular);
                return this;
            }

            public TransferenciaBancariaBuilder conValorTransferencia(int valor) 
            { 
                _transferenciaBancaria.ValorTransferencia = valor;
                return this;
            }

            public TransferenciaBancariaBuilder conCuentaDestino(Guid id, TipoCuenta tipoCuenta, string numeroCuenta, string bancoCuenta,string titular) 
            {
                _transferenciaBancaria.CuentaDestino = new Cuenta(id: id, tipoCuenta: tipoCuenta, numeroCuenta: numeroCuenta, bancoCuenta: bancoCuenta, titular: titular);
                return this;
            }

            public TransferenciaBancariaBuilder conFecha(DateTime fechaTransaccion) 
            { 
                _transferenciaBancaria.FechaTransaccion = fechaTransaccion;
                return this;
            }

        }

    }
}
