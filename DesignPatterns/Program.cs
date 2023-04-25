
using DesignPatterns.AbstractFactory.Implementations;
using DesignPatterns.Adapter.Implementations;
using DesignPatterns.Adapter.Interfaces;
using DesignPatterns.Builder;
using DesignPatterns.Builder.Interfaces;
using DesignPatterns.Factory;
using DesignPatterns.Factory.Interfaces;
using DesignPatterns.Prototype.Implementation;
using DesignPatterns.Singleton;
using DesignPatterns.Singleton.Entities;


#region Builder
//Builder pattern
//el patrón Builder se utiliza para crear objetos complejos paso a paso, separando la construcción del objeto de su representación,
//lo que permite la creación de diferentes tipos y representaciones de un objeto utilizando los mismos pasos de construcción.
//El patrón Builder es especialmente útil cuando se desea crear objetos complejos con diferentes partes opcionales o variaciones,
//sin tener que crear múltiples constructores complejos en la clase del objeto.
//IPersonaBuilder personaBuilder = new PersonaBuilder();
//PersonaDirector personaDirector = new PersonaDirector(personaBuilder);
//personaDirector.construirPersona();
//DesignPatterns.Builder.Entities.Persona persona = personaBuilder.ObtenerPersona();

//Console.WriteLine($"nombre: {persona.Nombre}, edad: {persona.Edad}, teléfono: {persona.Telefono},por último la direccion: {persona.Direccion}");
#endregion

#region Factory
//el patrón Factory se utiliza para proporcionar una interfaz para crear objetos sin especificar la clase exacta a crear,
//delegando esta responsabilidad a las subclases. El patrón Factory es especialmente útil cuando se desea crear objetos
//de diferentes tipos en tiempo de ejecución sin tener que modificar el código fuente existente. 
//IPersonaFactory personaFactory = new DesignPatterns.Factory.Implementations.PersonaFactory();
//DesignPatterns.Factory.Entities.Persona persona = personaFactory.CrearPersona("Andrés", "Guillén", 30, "Av siempre viva", "3213391383");
//Console.WriteLine($"Factory patron, nombre: {persona.Nombre} {persona.Apellido} tiene {persona.Edad} años");
#endregion



#region Abstract factory
//Abstract factory
//PersonaAbstractFactory factory = new PersonaAbstractFactory();
//var persona = factory.CrearPersona("Andres", 30, "Av siempre viva", "3213391383", "andres7guillen@gmail.com");
//Console.WriteLine($"Nombre: {persona.Nombre} con celular: {persona.Telefono}, correo: {persona.Email} ");
#endregion


#region Prototype
/*
 El patrón de diseño creacional Prototype se utiliza para crear nuevos objetos duplicando o clonando objetos existentes, en lugar de crear 
nuevos objetos desde cero. De esta manera, se puede reducir la complejidad y el tiempo de creación de objetos complejos, y se pueden modificar 
las propiedades de los objetos clonados según sea necesario.
La clave para implementar el patrón Prototype es que el objeto original debe ser capaz de clonarse a sí mismo mediante la implementación de 
un método Clone() que devuelva una copia del objeto.
 */
//PersonaPrototype persona = new PersonaPrototype(nombre: "Andres", edad: 30);
//Console.WriteLine(persona.ObtenerInformacion());
//var personaClon = (PersonaPrototype)persona.Clonar();
//personaClon.Nombre = "Jacinto";
//personaClon.Edad = 33;
//Console.WriteLine(personaClon.ObtenerInformacion());
#endregion

#region Singleton
//Singleton, este patron busca crear una unica instancia de una clase en toda la aplicacion.
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
#endregion

#region ADAPTER
//lo que busca el patron es que por medio de una interfaz se pueda obtener informacion de una clase sin tener que modificar esta clase.
//DesignPatterns.Adapter.Entities.Persona persona = new DesignPatterns.Adapter.Entities.Persona()
//{
//    Nombre = "Andrés",
//    Apellido = "Guillén",
//    Edad = 30,
//    Direccion = "Av siempre viva 123",
//    Telefono = "123456789"
//};

//IPersonaTarget personaAdapter = new PersonaAdapter(persona);
//string nombreCompleto = personaAdapter.ObtenerNombreCompleto(); // "Andres Guillen"
//int edad = personaAdapter.ObtenerEdad(); // 30
//Console.WriteLine(nombreCompleto + " " + edad);

#endregion