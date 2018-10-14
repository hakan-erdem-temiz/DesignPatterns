using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //get shape factory
            AbstractFactory shapeFactory = FactoryProducer.getFactory("SHAPE");

            //get an object of Shape Circle
            Shape shape1 = shapeFactory.GetShapes("CIRCLE");

            //call draw method of Shape Circle
            shape1.draw();

            //get an object of Shape Rectangle
            Shape shape2 = shapeFactory.GetShapes("RECTANGLE");

            //call draw method of Shape Rectangle
            shape2.draw();

            //get an object of Shape Square 
            Shape shape3 = shapeFactory.GetShapes("SQUARE");

            //call draw method of Shape Square
            shape3.draw();

            //get color factory
            AbstractFactory colorFactory = FactoryProducer.getFactory("COLOR");

            //get an object of Color Red
            Color color1 = colorFactory.GetColors("yellow");

            //call fill method of Red
            color1.Paint();

            //get an object of Color Green
            Color color2 = colorFactory.GetColors("Green");

            //call fill method of Green
            color2.Paint();

            //get an object of Color Blue
            Color color3 = colorFactory.GetColors("BLUE");

            //call fill method of Color Blue
            color3.Paint();
        }
    }
}
