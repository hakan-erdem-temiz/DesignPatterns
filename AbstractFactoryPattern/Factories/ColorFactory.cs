using AbstractFactoryPattern.Colors;
using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    class ColorFactory : AbstractFactory
    {
        public override IColor GetColors(string color)
        {

            if (color == null)
            {
                return null;
            }
            else if (string.Equals(color, "Blue", StringComparison.OrdinalIgnoreCase))
            {
                return new Blue();
            }
            else if (string.Equals(color, "Green", StringComparison.OrdinalIgnoreCase))
            {
                return new Green();
            }
            else if (string.Equals(color, "Yellow", StringComparison.OrdinalIgnoreCase))
            {
                return new Yellow();
            }
            else
            {
                return null;
            }

        }

        public override IShape GetShapes(string shape)
        {
            return null;
        }
    }
}
