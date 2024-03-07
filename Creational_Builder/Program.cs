// Builder => Proposito:
// se crean objetos complejos, es decir objetos que tienen relaciones con otros objetos y se crea paso paso, usando una clase builder
// por lo general una clase Builder dentro de la clase del objeto que se quiere crear.
// se usan palabras clave como: ConId, ConAlgo

using CreationalDomain.Entities.Builder;

TransferenciaBancaria transferencia = new TransferenciaBancaria.TransferenciaBancariaBuilder()
    .conId(Guid.NewGuid())
    .conValorTransferencia(11500000)
    .conCuentaOrigen(id: Guid.NewGuid(), tipoCuenta: new TipoCuenta(descripcion: "Ahorros"), numeroCuenta: "154-908-212", bancoCuenta: "Bancolombia", titular: "Andrés Guillén")
    .conCuentaDestino(id: Guid.NewGuid(), tipoCuenta: new TipoCuenta(descripcion: "Coriente"), numeroCuenta: "155-808-112", bancoCuenta: "Davivienda", titular: "Jenny Ochoa")
    .conFecha(fechaTransaccion: DateTime.Now)
    .build();

Console.WriteLine(transferencia.ToString());


