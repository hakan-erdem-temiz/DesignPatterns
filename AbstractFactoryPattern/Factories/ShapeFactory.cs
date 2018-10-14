using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    class ShapeFactory: AbstractFactory
    {
        public override Color GetColors(string color)
        {
            return null;
        }

        public override Shape GetShapes(string ShapeName)
        {
            if (ShapeName == null)
            {
                return null;
            }
            else if (string.Equals(ShapeName, "Circle", StringComparison.OrdinalIgnoreCase))
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
