using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class StorageEdit
    {
        private static StorageEdit Instance = new StorageEdit();

        //cannot be instantiated
        private StorageEdit(){}

        //only access with getInstance
        public static StorageEdit getInstance()
        {
            return Instance;
        }


        public void edit()
        {
            Console.WriteLine("Editing...");
        }

    }
}
