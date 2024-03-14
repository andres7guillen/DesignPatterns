using Structural_Bridge.Interfaces.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge.Classes.Shapes
{
    public class PrinterDrawingApi : IDrawingApi
    {
        public void DrawShape()
        {
            Console.WriteLine("Printing shape on the printer.");
        }
    }
}
