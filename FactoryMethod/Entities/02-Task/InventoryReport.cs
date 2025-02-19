using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities._02_Task
{
    public class InventoryReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generando reporte del inventario");
        }
    }
}
