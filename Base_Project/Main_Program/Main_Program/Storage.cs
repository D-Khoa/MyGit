using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Program
{
    class Storage
    {
        private static readonly Storage store = new Storage();
        public static Storage GetStorage()
        {
            return store;
        }
        public string text1;
        public static string text2;
    }
}
