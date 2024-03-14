using Structural_Bridge.Interfaces.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge.Classes.Shapes
{
    public class Circle : Shape
    {
        private byte _radius;
        public Circle(byte radius, IDrawingApi drawingApi) : base(drawingApi)
        {
            _radius = radius;
        }
        public override void Draw()
        {
            drawingApi.DrawShape();
        }
    }
}
