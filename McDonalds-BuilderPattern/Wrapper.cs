using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds_BuilderPattern
{
    class Wrapper : Interfaces.IPacking
    {
        public string Pack()
        {
            return "Wrapped";
        }
    }
}
