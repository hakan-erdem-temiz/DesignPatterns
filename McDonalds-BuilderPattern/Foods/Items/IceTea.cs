using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds_BuilderPattern.Foods.Items
{
    class IceTea : Drink
    {
        public override string Name()
        {
            return "IceTea";
        }

        public override float Price()
        {
            return 4.5f;
        }
    }
}
