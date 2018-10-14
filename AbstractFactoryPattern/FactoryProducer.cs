using AbstractFactoryPattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class FactoryProducer
    {
        public static AbstractFactory getFactory(string choice)
        {
            if (string.Equals(choice, "SHAPE",StringComparison.OrdinalIgnoreCase))
            {
                return new ShapeFactory();

            }
            else if (string.Equals(choice, "COLOR", StringComparison.OrdinalIgnoreCase))
            {
                return new ColorFactory();
            }

            return null;
        }
    }
}
