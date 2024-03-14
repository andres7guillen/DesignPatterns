using Structural_Bridge.Interfaces.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge.Classes.Shapes
{
    public abstract class Shape
    {
        protected IDrawingApi drawingApi;

        protected Shape(IDrawingApi drawingApi)
        {
            this.drawingApi = drawingApi;
        }

        public abstract void Draw();

    }
}
