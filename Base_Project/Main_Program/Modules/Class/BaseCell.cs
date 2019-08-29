using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modules
{
    public class BaseCell
    {
        public BaseCell() { }

        public const int _Width = 20;
        public const int _Height = 20;

        private int _Row;

        public int Row
        {
            get
            {
                return _Row;
            }

            set
            {
                _Row = value;
            }
        }

        private int _Col;

        public int Col
        {
            get
            {
                return _Col;
            }

            set
            {
                _Col = value;
            }
        }

        private Point _Position;

        public Point Position
        {
            get
            {
                return _Position;
            }

            set
            {
                _Position = value;
            }
        }

        private int _Owner;

        public int Owner
        {
            get
            {
                return _Owner;
            }

            set
            {
                _Owner = value;
            }
        }

        public BaseCell(int row, int col, Point pos, int owner)
        {
            _Row = row;
            _Col = col;
            _Position = pos;
            _Owner = owner;
        }
    }
}
