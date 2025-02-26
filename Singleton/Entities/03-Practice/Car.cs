using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Entities._03_Practice
{
    public class Car
    {
        private static Car _instance;
        public string Brand { get; private set; }
        public string Plate { get; private set; }
        public string Color { get; private set; }
        public int Year { get; private set; }

        private Car(string brand, string plate, string color, int year)
        {
            Brand = brand;
            Plate = plate;
            Color = color;
            Year = year;
        }

        public static Car GetInstance(string brand, string plate, string color, int year)
        {
            if (Car._instance == null) 
            {
                Car._instance = new Car(brand, plate, color, year);
            }
            return Car._instance;
        }

        public void ShowBrand() 
        {
            Console.WriteLine($"The brand's car is: {Brand}");
        }

    }
}
