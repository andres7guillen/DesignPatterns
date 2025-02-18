using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCreational.Entities._03_Practice
{
    public class Car
    {
        public string Brand { get; private set; }
        public string Color { get; private set; }
        public string Tipo { get; private set; }
        public string Direccion { get; private set; }
        public string Transmision { get; private set; }
        public int Year { get; private set; }
        public string Plate { get; private set; }
        public decimal Price { get; private set; }
        private Car(string brand, string color, string tipo, string direccion, string transmision, int year, string plate, decimal price) 
        { 
            Brand = brand;
            Color = color;
            Tipo = tipo;
            Direccion = direccion;
            Transmision = transmision;
            Year = year;
            Plate = plate;
            Price = price;
        }
        public string DescripcionVehiculo() 
        {
            return $"El vehiculo de placa: {Plate} es un modelo: {Year} de color: {Color} \n" +
                $"cuenta con una direccion: {Direccion} y es de transmision: {Transmision}";
        }

        public class Builder 
        {
            private string _brand;
            private string _color;
            private string _tipo;
            private string _direccion;
            private string _transmision;
            private int _year;
            private string _plate;
            private decimal _price;

            public Builder withBrand(string brand) 
            { 
                _brand = brand;
                return this;
            }

            public Builder withColor(string color) 
            { 
                _color = color;
                return this;
            }

            public Builder withTipo(string tipo) 
            { 
                _tipo = tipo;
                return this;
            }

            public Builder withDireccion(string direccion) 
            { 
                _direccion = direccion;
                return this;
            }

            public Builder withTransmision(string transmision) 
            { 
                _transmision = transmision;
                return this;
            }

            public Builder withYear(int year) 
            { 
                _year = year;
                return this;
            }

            public Builder withPlate(string plate) 
            { 
                _plate = plate;
                return this;
            }

            public Builder withPrice(decimal price) 
            { 
                _price = price;
                return this;
            }

            public Car Build() 
            {
                if (_year == null || _year < 1900) throw new ArgumentException("Model is required or the model is invalid.");
                if (string.IsNullOrEmpty(_brand)) throw new ArgumentException("Brand is required.");
                if (_year < 1886) throw new ArgumentException("Year must be greater than or equal to 1886.");
                if (_price <= 0) throw new ArgumentException("Price must be positive.");
                return new Car(brand: _brand, color: _color, tipo: _tipo, direccion: _direccion, transmision: _transmision, year: _year, plate: _plate, price: _price);
            }
        }

    }
}
