using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modules;

namespace Main_Program
{
    public partial class TestGame : Form
    {
        private BaseGame baseGame;
        private Graphics grs;

        public TestGame()
        {
            InitializeComponent();
            baseGame = new BaseGame();
            baseGame.CreateCellArray();
            grs = pnlBoard.CreateGraphics();
        }

        private void TestGame_Load(object sender, EventArgs e)
        {
        }

        private void pnlBoard_Paint(object sender, PaintEventArgs e)
        {
            baseGame.CreateBoard(grs);
            baseGame.CreateCellAgain(grs);
        }

        private void pnlBoard_MouseClick(object sender, MouseEventArgs e)
        {
            baseGame.PlayCheck(e.X, e.Y, grs);
        }
    }
}
