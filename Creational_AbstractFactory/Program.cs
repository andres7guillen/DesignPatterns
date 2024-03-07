// Abstract factory => Proposito:
// Proporciona una interfaz para crear familias de objetos relacionados o que dependen entre sí, 
// sin especificar sus clases concretas.

using Creational_AbstractFactory.Factories;

CreateVehiculosFactory abstractFactory = new CreateVehiculosFactory();
var carro = abstractFactory.crearAuto("Mazda");
var moto = abstractFactory.crearMoto();
var tren = abstractFactory.crearTren();

Console.WriteLine("Acciones del carro: ");
carro.Encender();
carro.Arrancar();
carro.Frenar();

Console.WriteLine("Acciones de la moto: ");
moto.Encender();
moto.Arrancar();
moto.Frenar();

Console.WriteLine("Acciones del tren: ");
tren.Encender();
tren.Arrancar();
tren.Frenar();