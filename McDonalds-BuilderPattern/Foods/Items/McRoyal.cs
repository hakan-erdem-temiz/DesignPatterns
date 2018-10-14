using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds_BuilderPattern.Foods.Items
{
    class McRoyal : Burger
    {
        public override string Name()
        {
            return "McRoyal";
        }

        public override float Price()
        {
            return 20.5f;
        }
    }
}
