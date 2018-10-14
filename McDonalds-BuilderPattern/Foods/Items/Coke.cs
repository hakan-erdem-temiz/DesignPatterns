using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds_BuilderPattern.Foods.Items
{
    class Coke: Drink
    {
        public override string Name()
        {
            return "Coke";
        }

        public override float Price()
        {
            return 5;
        }
    }
}
