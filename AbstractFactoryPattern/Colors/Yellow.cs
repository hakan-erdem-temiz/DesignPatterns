using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Colors
{
    class Yellow : Interfaces.Color
    {
        public void Paint( )
        {
            Console.WriteLine("This is Yellow");
        }
    }
}
