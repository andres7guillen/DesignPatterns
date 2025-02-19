namespace FactoryMethod.Entities._01_Tutorial;

public abstract class Restaurant
{
    protected abstract IBurger createBurger();
    public void orderBurger() 
    {
        var burger = this.createBurger();
        burger.Prepare();
    }
}
