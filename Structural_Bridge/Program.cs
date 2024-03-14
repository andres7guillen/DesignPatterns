#region Shape Bridge


//using Structural_Bridge.Classes.Shapes;

//Shape circle = new Circle(10, new WindowDrawingApi());
//circle.Draw();

//Shape rectangle = new Rectangle(10, 10, new PrinterDrawingApi());
//rectangle.Draw();

//Console.ReadKey();
#endregion Shape Bridge

#region HotDog Bridge
//using Structural_Bridge.Classes.HotDogs;

////Create machines
//HotDogMachineAmericano hotDogMachineAmericano = new HotDogMachineAmericano();
//HotDogMachineRanchero hotDogMachineRanchero = new HotDogMachineRanchero();

////Create factories
//SmallHotDogFactory smallHotDogFactory = new SmallHotDogFactory(hotDogMachineAmericano);
//MediumHotDogFactory mediumHotDogFactory = new MediumHotDogFactory(hotDogMachineRanchero);
//BigHotDogFactory bigHotDogFactory = new BigHotDogFactory(hotDogMachineAmericano);

////Start Factories
//smallHotDogFactory.PrepareHotDog();
//mediumHotDogFactory .PrepareHotDog();
//bigHotDogFactory.PrepareHotDog();

#endregion

#region Automovil Bridge

using Structural_Bridge.Classes.Autos;

CajaAutomatica cajaAutomatica = new CajaAutomatica();
CajaManual cajaManual = new CajaManual();
CajaTriptonica cajaTriptonica = new CajaTriptonica();

Auto carroMazdaManual = new Auto(marca: "Mazda", modelo: 2020, color: "Blanco", caja: cajaManual);
Auto carroToyotaAutomatico = new Auto(marca: "Toyota", modelo: 2016, color: "Negro", caja: cajaAutomatica);
Auto carroRenaultTriptonico = new Auto(marca: "Renault", modelo: 2021, color: "Blanco marfil", caja: cajaTriptonica);

carroMazdaManual.CambiarMarcha(3);
carroToyotaAutomatico.CambiarMarcha(5);
carroRenaultTriptonico.CambiarMarcha(4);
Console.ReadLine();


#endregion