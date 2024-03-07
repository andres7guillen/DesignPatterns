using Creational_FactoryMethod.Factories;

// Factory method: usa un metodo para crear objetos de una Clase.

Console.WriteLine("Factory method con un switch para crear Vehiculos: ");
VehiculoFactory factory = new VehiculoFactory();
var carro = factory.crearVehiculo("Carro");
var moto = factory.crearVehiculo("Moto");
var tren = factory.crearVehiculo("Tren");

Console.WriteLine("Acciones del carro");
carro.Encender();
carro.Arrancar();
carro.Frenar();

Console.WriteLine("Acciones de la moto");
moto.Encender();
moto.Arrancar();
moto.Frenar();

Console.WriteLine("Acciones del tren");
tren.Encender();
tren.Arrancar();
tren.Frenar();

Console.WriteLine("Factory method forma simple, donde se crea una Factory por un tipo especifico: ");
var CarroFactory = new CarroFactory();
var carro2 = CarroFactory.crearCarro("Renault Kwid");
Console.WriteLine("Acciones del carro 2");
carro2.Encender();
carro2.Arrancar();
carro2.Frenar();

