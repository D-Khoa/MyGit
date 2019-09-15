using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Program
{
    class BaseBoard
    {
        private int _rownum;
        private int _colnum;

        public BaseBoard()
        {
            _colnum = 0;
            _rownum = 0;
        }

        public BaseBoard(int rownum, int colnum)
        {
            _colnum = colnum;
            _rownum = rownum;
        }

        public void CreateBoard(Graphics g)
        {

        }
    }
}
