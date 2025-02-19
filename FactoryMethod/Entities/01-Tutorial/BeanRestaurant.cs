namespace FactoryMethod.Entities._01_Tutorial
{
    public  class BeanRestaurant : Restaurant
    {
        protected override IBurger createBurger()
        {
            return new BeanBurger();
        }
    }
}
