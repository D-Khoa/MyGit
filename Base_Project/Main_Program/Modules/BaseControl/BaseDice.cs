using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Modules
{
    public partial class BaseDice : UserControl
    {
        public static bool checkclick;
        public static string path = @"D:\GIT\DangKhoa\MyGit\";
        private Bitmap dices = (Bitmap)Image.FromFile(path + @"Base_Project\Main_Program\Modules\Dices.png");
        private Bitmap clone;
        private List<Rectangle> rec;
        private int dice1 = 1;
        private int dice2 = 1;

        public BaseDice()
        {
            InitializeComponent();
            clone = new Bitmap(138, 138);
            rec = new List<Rectangle>();
            Frame();
            picDice1.Image = clones(dice1);
            picDice2.Image = clones(dice2);
            checkclick = false;
        }

        private void Frame()
        {
            rec.Add(new Rectangle(0, 0, 138, 138));
            rec.Add(new Rectangle(138, 0, 138, 138));
            rec.Add(new Rectangle(276, 0, 138, 138));
            rec.Add(new Rectangle(414, 0, 138, 138));
            rec.Add(new Rectangle(552, 0, 138, 138));
            rec.Add(new Rectangle(690, 0, 138, 138));
        }

        private Bitmap clones(int num)
        {
            System.Drawing.Imaging.PixelFormat format = dices.PixelFormat;
            switch (num)
            {
                case 1:
                    clone = dices.Clone(rec[0], format);
                    break;
                case 2:
                    clone = dices.Clone(rec[1], format);
                    break;
                case 3:
                    clone = dices.Clone(rec[2], format);
                    break;
                case 4:
                    clone = dices.Clone(rec[3], format);
                    break;
                case 5:
                    clone = dices.Clone(rec[4], format);
                    break;
                case 6:
                    clone = dices.Clone(rec[5], format);
                    break;
            }
            return clone;
        }

        private void btnDice_Click(object sender, EventArgs e)
        {

            Thread t = new Thread(dicing);
            if (checkclick)
            {
                checkclick = false;
                btnDice.Text = "Dice";
            }
            else
            {
                checkclick = true;
                btnDice.Text = "Stop";
                t.Start();
            }

            if (dice1 == dice2)
            {
                BaseData.GetData().duplicate = true;
                //MessageBox.Show("Duplicate!!");
            }
            BaseData.GetData().sum_dice = dice1 + dice2;
            //MessageBox.Show("Sum = " + BaseData.GetData().sum_dice);
        }

        void dicing()
        {
            Random ran = new Random();
            while (checkclick)
            {
                dice1 = ran.Next(1, 7);
                picDice1.Image = clones(dice1);
                dice2 = ran.Next(1, 7);
                picDice2.Image = clones(dice2);
                Thread.Sleep(100);
            }
        }
    }
}
