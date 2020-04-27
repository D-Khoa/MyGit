using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_QRCodeSystem.Model
{
    public class PrintClass
    {
        public int mTop { get; set; }
        public int mBot { get; set; }
        public int mLeft { get; set; }
        public int mRight { get; set; }
        public int ItemWidth { get; set; }
        public int ItemHeight { get; set; }
        public int PageWidth { get; set; }
        public int PageHeight { get; set; }
        public Bitmap bmpPrintPage { get; set; }
        bool firstPage, newPage;

        public PrintClass(int w, int h, int mT, int mB, int mL, int mR)
        {
            mTop = mT;
            mBot = mB;
            mLeft = mL;
            mRight = mR;
            PageWidth = w;
            PageHeight = h;
            ItemWidth = 0;
            ItemHeight = 0;
            firstPage = true;
            newPage = true;
        }

        public Image PrintDataGridView(DataGridView dgv)
        {
            ItemWidth = mLeft;
            ItemHeight = mTop;
            bmpPrintPage = new Bitmap(ItemWidth, ItemHeight);
            Graphics gp = Graphics.FromImage(bmpPrintPage);
            //while(ItemHeight <= PageHeight)
            {
                if(firstPage)
                {
                    gp.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(mLeft, mTop, PageWidth - mLeft - mRight, 100));
                    ItemHeight += 100;
                }
                if (newPage)
                {
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        gp.DrawRectangle(new Pen(Color.Red), new Rectangle(ItemWidth, ItemHeight, dgv.Columns[col].Width, 200));
                        ItemWidth += dgv.Columns[col].Width;
                    }
                }
            }
            return bmpPrintPage;
        }
    }
}
