using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds_BuilderPattern.Foods.Items
{
    class McChicken : Burger
    {
        public override string Name()
        {
            return "McChicken";
        }

        public override float Price()
        {
            return 15;
        }
    }
}
