using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCreational.Entities.Tutorial
{
    public class Computer
    {
        public string CPU { get; set; } = "CPU Not defined";
        public string RAM { get; set; } = "RAM Not defined";
        public string Storage { get; set; } = "Storage Not defined";
        public string? GPU { get; set; }

        public void DisplayConfiguration() 
        {
            Console.WriteLine($"Configuración de la computadora: ");
            Console.WriteLine($"CPU: {this.CPU}");
            Console.WriteLine($"RAM: {this.RAM}");
            Console.WriteLine($"Storage: {this.Storage}");
            Console.WriteLine($"GPU: {this.GPU ?? "No tiene GPU"}");
        }
    }
    public class ComputerBuilder
    {
        private Computer _Computer { get; set; }

        public ComputerBuilder()
        {
            _Computer = new Computer();
        }

        public ComputerBuilder setCpu(string cpu)
        {
            this._Computer.CPU = cpu;
            return this;
        }

        public ComputerBuilder setRAM(string ram)
        {
            this._Computer.RAM = ram;
            return this;
        }

        public ComputerBuilder setStorage(string storage)
        {
            this._Computer.Storage = storage;
            return this;
        }

        public ComputerBuilder setGPU(string gpu)
        {
            this._Computer.GPU = gpu;
            return this;
        }

        public Computer Build()
        {
            return this._Computer;
        }

    }
}
