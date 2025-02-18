// BUILDER
using BuilderCreational.Entities.Tutorial;
using BuilderCreational.Entities.Task;
using BuilderCreational.Entities._03_Practice;

//Computer
//Console.WriteLine("Basic Computer: ");
var basicComputer = new ComputerBuilder()
    .setCpu("Intel Core 2 Dúo")
    .setRAM("4 GB")
    .setStorage("256 GB")
    .Build();
//basicComputer.DisplayConfiguration();

//Console.WriteLine("Gaming Computer: ");
var gameingComputer = new ComputerBuilder()
    .setCpu("Intel i9")
    .setRAM("32 GB")
    .setStorage("1.024 GB")
    .setGPU("Nvidia RTX 5090")
    .Build();
//gameingComputer.DisplayConfiguration();


// Task SQL Query Builder
var usersQuery = new QueryBuilder("users")
    .select(["id", "name", "email"]) //["id", "name", "email"]
    .where("age > 18")
    .where("country = 'Cri'")
    .orderBy("name", "ASC")
    .limit(10)
    .where("Email = 'andres7guillen@gmail.com'")
    .Build()
    .Execute();
//Console.WriteLine(usersQuery);

// Practice Car
var kwid = new Car.Builder()
    .withPlate("JMX950")
    .withTransmision("Mecanica")
    .withDireccion("Electro-asistida")
    .withBrand("Renault")
    .withYear(2021)
    .withPrice(35000000)
    .withColor("White")
    .withTipo("Hatchback")
    .Build();
Console.WriteLine(kwid.DescripcionVehiculo());
