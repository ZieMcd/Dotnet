using System.Collections.Generic;

namespace Methode_Overloading
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes) 
        {
            foreach ( var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}