using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    abstract class AbstractFactory
    {
        public abstract Color GetColors(string color);
        public abstract Shape GetShapes(string shape);


    }
}
