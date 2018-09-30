﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Shapes
{
    class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
