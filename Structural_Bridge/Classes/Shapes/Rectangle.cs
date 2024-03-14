using Structural_Bridge.Interfaces.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge.Classes.Shapes
{
    public class Rectangle : Shape
    {
        private byte _width;
        private byte _height;
        public Rectangle(byte width, byte height, IDrawingApi drawingApi) : base(drawingApi)
        {
            _height = height;
            _width = width;
        }
        public override void Draw()
        {
            drawingApi.DrawShape();
        }
    }
}
