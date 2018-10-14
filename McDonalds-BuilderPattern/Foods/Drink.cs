using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McDonalds_BuilderPattern.Interfaces;

namespace McDonalds_BuilderPattern.Foods
{
    abstract class Drink : IFood
    {
        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract string Name();

        public abstract float Price();
    }
}
