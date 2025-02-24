


using Prototype.Entities._01_Tutorial;
using Prototype.Entities._02_Task;
using Prototype.Entities._03_Practice;

#region Tutorial
//Document document = new Document("cotizacion","500 usd","Andres Guillen");
//var document2 = document.Clone();
//document2.Title = "Nueva cotizacion";
//Console.WriteLine("Document: {0}",document);
//Console.WriteLine(document.DisplayInfo());

//Console.WriteLine("Document2: {0}",document2);
//Console.WriteLine(document2.DisplayInfo());
#endregion 

#region Task
//Pokemon pokemon = new Pokemon("Charmander", "Fuego", 1, new List<string> { "Llamarada", "Arañazo" });
//Console.WriteLine("Pokemon: {0}", pokemon);
//Console.WriteLine(pokemon.DisplayInfo());

//var pokemon2 = pokemon.Clone();
//pokemon2.Name = "Charmeleon";
//pokemon2.Level = 16;
//pokemon2.Attacks.Add("Lanza-llamas");

//Console.WriteLine("Pokemon: {0}", pokemon2);
//Console.WriteLine(pokemon2.DisplayInfo());
#endregion

#region Practice
Car kwid = new Car("Hatchback", "Renault", "JMX930", 2021);
Console.WriteLine("Carro: {0}", kwid);
Console.WriteLine(kwid.DisplayInfo());

var camaro = kwid.Clone();
camaro.Year = 2023;
camaro.Plate = "JMX950";
camaro.Brand = "Chevrolet";
camaro.Type = "Sedan";
Console.WriteLine("Carro: {0}", camaro);
Console.WriteLine(camaro.DisplayInfo());

#endregion
