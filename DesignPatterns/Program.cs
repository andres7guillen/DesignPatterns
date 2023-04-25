
using DesignPatterns.AbstractFactory.Implementations;
using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Prototype.Implementation;
using DesignPatterns.Singleton;
using DesignPatterns.Singleton.Entities;


//Builder pattern
//PersonaBuilder personaBuilder = new PersonaBuilder();
//Persona persona = personaBuilder
//    .withNombre("Andrés Guillen")
//    .withDireccion("av siempre viva 123")
//    .withEdad(30)
//    .withEmail("andres7guillen@gmail.com")
//    .withTelefono("3213391383")
//    .Build();
//Console.WriteLine($"nombre: {persona.Nombre}, edad: {persona.Edad}, teléfono: {persona.Telefono}, correo: {persona.Email} y por último la direccion: {persona.Direccion}");



//Factory
//var persona1 = PersonaFactory.CrearPersona(nombre: null, edad: 22, direccion: "Av siempre viva 123", telefono: "3213391386", email: "andres7guillen@gmail.com");
//Console.WriteLine(persona1);



//Abstract factory
//PersonaAbstractFactory factory = new PersonaAbstractFactory();
//var persona = factory.CrearPersona("Andres", 30, "Av siempre viva", "3213391383", "andres7guillen@gmail.com");
//Console.WriteLine($"Nombre: {persona.Nombre} con celular: {persona.Telefono}, correo: {persona.Email} ");



//Prototype
//PersonaPrototype persona = new PersonaPrototype(nombre: "Andres", edad: 30);
//Console.WriteLine(persona.ObtenerInformacion());
//var personaClon = (PersonaPrototype)persona.Clonar();
//personaClon.Nombre = "Jacinto";
//personaClon.Edad = 33;
//Console.WriteLine(personaClon.ObtenerInformacion());

//Singleton
//DesignPatterns.Singleton.Entities.Persona instanciaPersona = PersonaSingleton.GetInstance();
//instanciaPersona.Nombre = "Juan";
//instanciaPersona.Edad = 30;
//instanciaPersona.Direccion = "Calle 123";
//instanciaPersona.Telefono = "123456789";
//instanciaPersona.Email = "juan@example.com";
//Console.WriteLine($"usando singleton queda asi: Nombre: {instanciaPersona.Nombre}, edad: {instanciaPersona.Edad}");
//try
//{
//    DesignPatterns.Singleton.Entities.Persona instanciaPersona2 = PersonaSingleton.GetInstance();

//}
//catch (Exception e)
//{
//	Console.WriteLine(e.Message);
//	throw e;
//}

//