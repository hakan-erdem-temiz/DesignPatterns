using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Rectangle : Interfaces.Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
