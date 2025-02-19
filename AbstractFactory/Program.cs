#region Tutorial
//using AbstractFactory.Entities._01_Tutorial;

//void executeRestaurant(RestaurantFactory restaurantFactory) 
//{
//    var burger = restaurantFactory.createBurger();
//    burger.Prepare();

//    var drink = restaurantFactory.createDrink();
//    drink.Pour();
//}
//executeRestaurant(new HealthyRestaurantFactory());
#endregion

#region Task
//using AbstractFactory.Entities._02_Task;

//void ExecuteVehicelFactory(VehicleFactory vehicleFactory) 
//{
//    var car = vehicleFactory.CreateCar();
//    var engine = vehicleFactory.CreateEngine();

//    car.Assemble();
//    engine.Start();
//}
//ExecuteVehicelFactory(new ElectricVehicleFactory());
//ExecuteVehicelFactory(new GasVehicleFactory());

#endregion

#region Practice
using AbstractFactory.Entities._03_Practice;

void ExecuteFactory(BallFactory ballFactory) 
{ 
    var ball = ballFactory.CreateBall();
    ball.Bounce();
}

ExecuteFactory(new SoccerBallFactory());
ExecuteFactory(new BasketBallFactory());

#endregion