﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Square : Interfaces.Shape
    {
        public void draw()
        {
            Console.WriteLine("Square");
        }
    }
}
