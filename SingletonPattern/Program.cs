using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             For example, if we are going to implement singleton for an object
             in a web project, the first example created must be locked. 
             If two different threads make a request repeatedly, 
             the other thread waits until the result is finished.
             */
            var manageStorage = StorageEdit.getInstance();
            manageStorage.edit();

            Console.ReadKey();

        }
    }
}
