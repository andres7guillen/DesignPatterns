using FactoryMethod.Entities._01_Tutorial;
using FactoryMethod.Entities._02_Task;
using FactoryMethod.Entities._03_Practice;
#region TUTORIAL
//Restaurant restaurant;

//Console.WriteLine("Que tipo de hamburguesa quieres? Chicken/Beef/Bean");
//var seleccionTipo = Console.ReadLine();
//if (seleccionTipo?.ToLower() == "chicken")
//{
//    restaurant = new ChickenRestaurant();
//}
//else if (seleccionTipo?.ToLower() == "beef")
//{
//    restaurant = new BeefRestaurant();
//}
//else if (seleccionTipo.ToLower() == "bean") 
//{
//    restaurant = new BeanRestaurant();
//}
//else
//{
//    Console.WriteLine("opcion invalida");
//    throw new Exception("Opcion invalida");
//}

//restaurant.orderBurger();

#endregion

#region TASK
//TASK
//ReportFactory reportFactory;
//Console.WriteLine("Que tipo de reporte quieres? Sales/Inventary");
//var seleccionTipo = Console.ReadLine();
//if (seleccionTipo?.ToLower() == "sales")
//{
//    reportFactory = new SalesReportFactory();
//}
//else if (seleccionTipo?.ToLower() == "inventary")
//{
//    reportFactory = new InventaryReportFactory();
//}
//else
//{
//    Console.WriteLine("opcion invalida");
//    throw new Exception("Opcion invalida");
//}
//reportFactory.Generate();
#endregion

#region PRACTICE
CarFactory carFactory;
Console.WriteLine("Que tipo de carro quieres? Sedan/Hatchback");
var seleccionTipo = Console.ReadLine();
if (seleccionTipo?.ToLower() == "sedan")
{
    carFactory = new SedanCarFactory();
}
else if (seleccionTipo.ToLower() == "hatchback")
{
    carFactory = new HatchBackCarFactory();
}
else 
{
    throw new Exception("Campo invalido");
}
carFactory.Generate();

#endregion