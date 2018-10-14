using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory sf = new ShapeFactory();
            IShape shape= sf.getShapes("square");
            shape.draw();
            Console.ReadKey();
        }
    }
} 
