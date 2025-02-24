using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Entities._03_Practice
{
    public class Car
    {
        public string Brand { get; set; }
        public string Plate { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }
        public Car(string type, string brand, string plate, int year)
        {
            Type = type;
            Brand = brand;
            Plate = plate;
            Year = year;
        }

        public Car Clone() 
        {
            return new Car(this.Type, this.Brand, this.Plate, this.Year);
        }

        public string DisplayInfo() 
        {
            return $"El carro de marca: {this.Brand} es modelo: {this.Year}, es tipo: {this.Type} y la placa es: {this.Plate}";
        }
        
    }
}
