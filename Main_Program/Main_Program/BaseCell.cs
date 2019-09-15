using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Main_Program
{
    class BaseCell
    {
        public const int _Width = 50;
        public const int _Heigh = 50;
        public int row { get; set; }
        public int col { get; set; }
        public Point loc { get; set; }
        public int owner { get; set; }

    }
}
