using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class BaseBoard
    {
        private int _Row;
        private int _Col;

        public int Row
        {
            get
            {
                return _Row;
            }
        }

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

        public BaseBoard()
        {
            _Row = 0;
            _Col = 0;
        }

        public BaseBoard(int Row, int Col)
        {
            _Row = Row;
            _Col = Col;
        }

        public void CreateBoard(Graphics g)
        {
            for(int i = 0; i <= _Col; i++)
            {
                g.DrawLine(BaseGame.pen, i * BaseCell._Width, 0, i * BaseCell._Width, _Row * BaseCell._Height);
            }
            for (int j = 0; j <= _Row; j++)
            {
                g.DrawLine(BaseGame.pen, 0, j * BaseCell._Height, _Col * BaseCell._Width, j * BaseCell._Height);
            }
        }

        public void CreateUser(Graphics g, Point pos, SolidBrush sb)
        {
            g.FillEllipse(sb, pos.X + 1, pos.Y + 1, BaseCell._Width - 2, BaseCell._Height - 2);
        }
    }
}
