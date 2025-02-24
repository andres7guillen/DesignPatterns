using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutabilityWithCopy.Entities._03_Practice
{
    public class Car
    {
        public string Brand { get; private set; }
        public string Plate { get; private set; }
        public string Color { get; private set; }
        public int Year { get; private set; }

        public Car(string brand, string plate, string color, int year)
        {
            Brand = brand;
            Plate = plate;
            Color = color;
            Year = year;
        }

        public Car CopyWith(string brand = null, string plate = null, string color = null, int?  year = null) 
        {
            return new Car(brand: brand ?? Brand, plate: plate ?? Plate, color: color ?? Color, year: year ?? Year);
        }

        public void DisplayInfo() 
        {
            Console.WriteLine($"Car's brand is: {Brand}, is from year: {Year}, color is: {Color} and the license plate is: {Plate}");
        }

    }
}
