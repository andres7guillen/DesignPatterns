using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryFunction.Entities._01_Tutorial;

public class Car
{
    public string Brand { get; }
    public string Model { get; }
    public int Year { get; }
    public string Color { get; }
    public decimal Price { get; }

    private Car(string brand, string model, int year, string color, decimal price)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
        Price = price;
    }

    // Factory Function
    public static Car Create(string brand, string model, int year, string color, decimal price)
    {
        if (year < 1886 || year > DateTime.Now.Year)
        {
            throw new ArgumentException("El año no es válido.");
        }

        return new Car(brand, model, year, color, price);
    }

    public void DisplayInfo() 
    {
        Console.WriteLine($"Car is made by: {Brand}, is a model: {Model} and it's color is: {Color}");
    }
}

public static class DiscountFactory
{
    public static Func<Car, decimal> CreateDiscountFunction(int currentYear)
    {
        return car =>
        {
            int age = currentYear - car.Year;
            return age > 10 ? car.Price * 0.20m : car.Price * 0.05m; // 20% si el auto tiene más de 10 años, 5% si no
        };
    }
}
