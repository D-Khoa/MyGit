using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseWindow
{
    interface iTest
    {
        void printout(string s);
    }

    class mTest : iTest
    {
        public void printout(string s)
        {
            Console.WriteLine("CAlling: {0}", s);
        }
    }
}
