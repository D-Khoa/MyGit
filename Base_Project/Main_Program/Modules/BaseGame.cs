using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class BaseGame
    {
        public static Pen pen;
        public static SolidBrush usWhite;
        public static SolidBrush usBlack;

        private BaseCell[,] _CellArray;
        private BaseBoard _Board;
        private List<BaseCell> listCell;
        private int _playerRoute;

        public BaseGame()
        {
            pen = new Pen(Color.Green);
            usWhite = new SolidBrush(Color.White);
            usBlack = new SolidBrush(Color.Black);
            _Board = new BaseBoard(20, 20);
            _CellArray = new BaseCell[_Board.Row, _Board.Col];
            listCell = new List<BaseCell>();
            _playerRoute = 1;
        }

        public void CreateBoard(Graphics g)
        {
            _Board.CreateBoard(g);
        }

        public void CreateCellArray()
        {
            for(int i = 0; i < _Board.Row; i++)
            {
                for(int j = 0; j < _Board.Col; j++)
                {
                    _CellArray[i, j] = new BaseCell(i, j, new Point(j * BaseCell._Width, i * BaseCell._Height), 0);
                }
            }
        }

        public bool PlayCheck(int MouseX, int MouseY, Graphics g)
        {
            if (MouseX % BaseCell._Width == 0 || MouseY % BaseCell._Height == 0)
                return false;
            int Col = MouseX / BaseCell._Width;
            int Row = MouseY / BaseCell._Height;
            if (_CellArray[Row, Col].Owner != 0)
                return false;

            switch(_playerRoute)
            {
                case 1:
                    _CellArray[Row, Col].Owner = 1;
                    _Board.CreateUser(g, _CellArray[Row, Col].Position, usBlack);
                    _playerRoute = 2;
                    break;
                case 2:
                    _CellArray[Row, Col].Owner = 2;
                    _Board.CreateUser(g, _CellArray[Row, Col].Position, usWhite);
                    _playerRoute = 1;
                    break;
            }
            listCell.Add(_CellArray[Row, Col]);
            return true;
        }

        public void CreateCellAgain(Graphics g)
        {
            foreach(BaseCell cell in listCell)
            {
                if(cell.Owner == 1)
                    _Board.CreateUser(g, cell.Position, usBlack);
                else if(cell.Owner == 2)
                    _Board.CreateUser(g, cell.Position, usWhite);
            }
        }
    }
}
