using FactoryPattern.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryPattern
{
    class ShapeFactory
    {
        public Shape getShapes(string ShapeName)
        {
            if (ShapeName == null)
            {
                return null;
            }else if (string.Equals(ShapeName, "Circle", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            }
            else if (string.Equals(ShapeName, "Rectangle", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }
            else if (string.Equals(ShapeName, "Square", StringComparison.OrdinalIgnoreCase))
            {
                 return new Square();
            }
            else
            {
                return null;
            }
        }
    }
}
