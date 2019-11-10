using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKMES.Common
{
    public class BaseCell
    {
        public int col { get; set; }
        public int row { get; set; }
        public int index { get; set; }

        public BaseCell(int columns, int rows)
        {
            col = columns;
            row = rows;
        }

        public void cell()
        {

        }
    }
}
