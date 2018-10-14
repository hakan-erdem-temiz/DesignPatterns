using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McDonalds_BuilderPattern.Interfaces;

namespace McDonalds_BuilderPattern.Foods
{
    abstract class Burger : IFood
    {
        abstract public string Name();

        abstract public float Price();

        public IPacking Packing()
        {
            return new Bottle();
        }
    }
}
