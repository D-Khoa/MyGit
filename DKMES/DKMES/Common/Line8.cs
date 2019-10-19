using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKMES.Common
{
    public class Line8
    {
        public Image img;
        public Graphics gp;
        public Bitmap bmp;
        public Bitmap32 bmp32;
        public Pen pen = new Pen(Color.Red);

        public Line8(Image inImage)
        {
            img = inImage;
            gp = Graphics.FromImage(img);
            bmp = new Bitmap(img);
            bmp32 = new Bitmap32(bmp);
        }

        public bool line1()
        {
            //for(int i = 0; i < img.Height; i++)
            //{
            //    Point p1 = new Point(0, i);
            //    Point p2 = new Point(img.Width, i);
            //    gp.DrawLine(pen, p1, p2);
            //}

            bmp32.LockBitmap();
            int c = 0;
            for(int i = 0; i < bmp32.ImageBytes.Count() - 4; i += 4)
            {
                if (c == 28) c = 0;

                c++;
            }
            return true;
        }
    }
}
