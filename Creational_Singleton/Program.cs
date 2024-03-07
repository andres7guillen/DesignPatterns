
using CreationalDomain.Entities.Singleton;

Persona objPersona = Persona.getPersona();
objPersona.Nombre = "Andres";
Console.WriteLine($"el nombre de la primera instancia es: {objPersona.Nombre}");

Persona objPersona2 = Persona.getPersona();
Console.WriteLine($"el nombre de la segunda instancia es: {objPersona2.Nombre}");

