namespace FactoryMethod.Entities._03_Practice;

public abstract class CarFactory
{
    protected abstract ICar CreateCar();
    public void Generate() 
    {
        var car = this.CreateCar();
        car.EncenderCarro();
        car.ApagarCarro();
    }        

}
