//#region TUTORIAL
//using Singleton.Entities._01_Tutorial;

//var gokuDragonBalls = DragonBall.GetInstance();
//gokuDragonBalls.CollectBall();
//gokuDragonBalls.CollectBall();
//gokuDragonBalls.CollectBall();
//gokuDragonBalls.CollectBall();

//var vegetaDragonBalls = DragonBall.GetInstance();
//vegetaDragonBalls.CollectBall();
//vegetaDragonBalls.CollectBall();
//vegetaDragonBalls.CollectBall();



//gokuDragonBalls.InvokeShenlong();

//vegetaDragonBalls.InvokeShenlong();

//#endregion

#region TASK
//using Singleton.Entities._02_Task;

//var db1 = DataBaseConnection.GetInstance("Sql");
//db1.Connect();
//db1.Connect();
//db1.Disconnect();
//var db2 = DataBaseConnection.GetInstance("Mongo");
//db2.Connect();

//Console.WriteLine($"Son iguales: {db1 == db2}");

#endregion

#region PRACTICE
using Singleton.Entities._03_Practice;

var car1 = Car.GetInstance("Renault", "JMX930", "White", 2021);
car1.ShowBrand();

var car2 = Car.GetInstance("Mazda", "JME456", "Black", 2025);
car2.ShowBrand();

#endregion


