using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace DKMES.Common
{
    public class Bitmap32
    {
        // Provide public access to the picture's byte data.
        public byte[] ImageBytes;
        public int RowSizeBytes;

        // A reference to the Bitmap.
        private Bitmap m_Bitmap;

        // Save a reference to the bitmap.
        public Bitmap32(Bitmap bm)
        {
            m_Bitmap = bm;
        }

        // Bitmap data.
        private BitmapData m_BitmapData;

        // Lock the bitmap's data.
        public void LockBitmap()
        {
            // Lock the bitmap data.
            Rectangle bounds = new Rectangle(
                0, 0, m_Bitmap.Width, m_Bitmap.Height);
            m_BitmapData = m_Bitmap.LockBits(bounds,
                ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);
            RowSizeBytes = m_BitmapData.Stride;

            // Allocate room for the data.
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            ImageBytes = new byte[total_size];

            // Copy the data into the ImageBytes array.
            Marshal.Copy(m_BitmapData.Scan0, ImageBytes, 0, total_size);
        }

        // Copy the data back into the Bitmap
        // and release resources.
        public void UnlockBitmap()
        {
            // Copy the data back into the bitmap.
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            Marshal.Copy(ImageBytes, 0, m_BitmapData.Scan0, total_size);

            // Unlock the bitmap.
            m_Bitmap.UnlockBits(m_BitmapData);

            // Release resources.
            ImageBytes = null;
            m_BitmapData = null;
        }

        #region XU LY PIXEL
        public Color GetPixel(int x, int y)
        {
            Color color = new Color();
            byte R, G, B, A;
            int line = m_BitmapData.Stride;
            int i = line * y + x * 4;
            if (i <= ImageBytes.Length - 4)
            {
                B = ImageBytes[i];
                G = ImageBytes[i + 1];
                R = ImageBytes[i + 2];
                A = ImageBytes[i + 3];
                color = Color.FromArgb(A, R, G, B);
            }
            return color;
        }

        public void SetPixel(int x, int y, Color color)
        {
            int line = m_BitmapData.Stride;
            int i = line * y + x * 4;
            if (i <= ImageBytes.Length - 4)
            {
                ImageBytes[i] = color.B;
                ImageBytes[i + 1] = color.G;
                ImageBytes[i + 2] = color.R;
                ImageBytes[i + 3] = color.A;
            }
        }
        #endregion

        #region TIM OFFSET, CONVERT TO HEX
        public byte[] ToHex()
        {
            ToBlackWhite();
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            int n = 0;
            byte c;
            byte[] h = new byte[8192];
            for (int i = 0; i < total_size - 4; i += 4, n++)
            {
                c = ImageBytes[i];
                h[n] = c;
            }
            return h;
        }

        public int Offset()
        {
            Color c = new Color();
            byte sR, sG, sB, cR, cG, cB;
            int ofs, cou;
            sR = 0;
            sG = 0;
            sB = 0;
            cR = 0;
            cG = 0;
            cB = 0;
            for (int y = 0; y < m_Bitmap.Height; y++)
            {
                for (int x = 0; x < m_Bitmap.Width; x++)
                {
                    c = GetPixel(x, y);
                    if (c.R != 0)
                    {
                        cR++;
                        sR += c.R;
                    }
                    if (c.G != 0)
                    {
                        cG++;
                        sG += c.G;
                    }
                    if (c.B != 0)
                    {
                        cB++;
                        sB += c.B;
                    }
                }
            }
            ofs = 0;
            cou = 0;
            if (cR != 0) { ofs += sR / cR; cou++; }
            if (cG != 0) { ofs += sG / cG; cou++; }
            if (cB != 0) { ofs += sB / cB; cou++; }
            if (cou == 0) cou = 1;
            return ofs / cou;
        }
        #endregion

        #region CONVERT COLOR
        public void GetRed(byte opt)
        {
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            for (int i = 0; i < total_size - 4; i += 4)
            {
                ImageBytes[i] = 0;
                ImageBytes[i + 1] = 0;
                ImageBytes[i + 2] = ImageBytes[i + 2];
                ImageBytes[i + 3] = opt;
            }
        }

        public void GetGreen(byte opt)
        {
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            for (int i = 0; i < total_size - 4; i += 4)
            {
                ImageBytes[i] = 0;
                ImageBytes[i + 1] = ImageBytes[i + 1];
                ImageBytes[i + 2] = 0;
                ImageBytes[i + 3] = opt;
            }
        }

        public void GetBlue(byte opt)
        {
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            for (int i = 0; i < total_size - 4; i += 4)
            {
                ImageBytes[i] = ImageBytes[i];
                ImageBytes[i + 1] = 0;
                ImageBytes[i + 2] = 0;
                ImageBytes[i + 3] = opt;
            }
        }

        public void ToGrayScale(byte opt)
        {
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            byte c;
            for (int i = 0; i < total_size - 4; i += 4)
            {
                c = (byte)((ImageBytes[i] * 0.11 + ImageBytes[i + 1] * 0.59 + ImageBytes[i + 2] * 0.3) / 3);
                ImageBytes[i] = c;
                ImageBytes[i + 1] = c;
                ImageBytes[i + 2] = c;
                ImageBytes[i + 3] = opt;
            }
        }

        public void ToBlackWhite()
        {
            //ToGrayScale(255);
            int offset = Offset();
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            for (int i = 0; i < total_size - 4; i += 4)
            {
                if ((ImageBytes[i] > offset) && (ImageBytes[i + 1] > offset) && (ImageBytes[i + 2] > offset))
                {
                    ImageBytes[i] = 255;
                    ImageBytes[i + 1] = 255;
                    ImageBytes[i + 2] = 255;
                    ImageBytes[i + 3] = 255;
                }
                else
                {
                    ImageBytes[i] = 0;
                    ImageBytes[i + 1] = 0;
                    ImageBytes[i + 2] = 0;
                    ImageBytes[i + 3] = 255;
                }
            }
        }
        #endregion

        #region FILTER
        public void FloydSteinberg(byte offset)
        {
            ToGrayScale(255);
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            int line = m_BitmapData.Stride;
            byte c, c1, c2, c3, c4, cn;
            int quant;
            for (int i = 4; i < total_size - line - 4; i += 4)
            {
                c = ImageBytes[i];
                cn = (byte)(Math.Round((double)(c / offset)) * 255);
                quant = c - cn;
                c1 = ImageBytes[i + 4];
                c2 = ImageBytes[i + line - 4];
                c3 = ImageBytes[i + line];
                c4 = ImageBytes[i + line + 4];
                ImageBytes[i] = cn;
                ImageBytes[i + 1] = cn;
                ImageBytes[i + 2] = cn;
                ImageBytes[i + 4] = (byte)(c1 + quant * 7 / 16);
                ImageBytes[i + 5] = (byte)(c1 + quant * 7 / 16);
                ImageBytes[i + 6] = (byte)(c1 + quant * 7 / 16);
                ImageBytes[i + line - 4] = (byte)(c2 + quant * 3 / 16);
                ImageBytes[i + line - 3] = (byte)(c2 + quant * 3 / 16);
                ImageBytes[i + line - 2] = (byte)(c2 + quant * 3 / 16);
                ImageBytes[i + line] = (byte)(c3 + quant * 5 / 16);
                ImageBytes[i + line + 1] = (byte)(c3 + quant * 5 / 16);
                ImageBytes[i + line + 2] = (byte)(c3 + quant * 5 / 16);
                ImageBytes[i + line + 4] = (byte)(c4 + quant * 1 / 16);
                ImageBytes[i + line + 5] = (byte)(c4 + quant * 1 / 16);
                ImageBytes[i + line + 6] = (byte)(c4 + quant * 1 / 16);
            }
        }

        public void Vector()
        {
            Color c1 = new Color();
            Color c2 = new Color();
            Color c3 = new Color();
            Color c4 = new Color();
            Color c5 = new Color();
            Color c6 = new Color();
            Color c7 = new Color();
            Color c8 = new Color();
            Color c9 = new Color();

            for (int y = 0; y < m_Bitmap.Height; y++)
            {
                for (int x = 0; x < m_Bitmap.Width; x++)
                {
                    if (x > 0)
                    {
                        if (y > 0)
                            c1 = GetPixel(x - 1, y - 1);
                        c4 = GetPixel(x - 1, y);
                        if (y < m_Bitmap.Height)
                            c7 = GetPixel(x - 1, y + 1);
                    }
                    if (x < m_Bitmap.Width)
                    {
                        if (y > 0)
                            c3 = GetPixel(x + 1, y - 1);
                        c6 = GetPixel(x + 1, y);
                        if (y < m_Bitmap.Height)
                            c9 = GetPixel(x + 1, y + 1);
                    }
                    if (y > 0)
                        c2 = GetPixel(x, y - 1);
                    c5 = GetPixel(x, y);
                    if (y < m_Bitmap.Height)
                        c8 = GetPixel(x, y + 1);

                    if ((c5.R >= c1.R) && (c5.R >= c2.R) && (c5.R >= c3.R) && (c5.R >= c4.R) && (c5.R >= c6.R) && (c5.R >= c7.R) && (c5.R >= c8.R) && (c5.R >= c9.R) && (c5.R == 255))
                    {
                        SetPixel(x, y, Color.FromArgb(255, 0, 0));
                    }
                    else
                        SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            }
        }

        public void FilterVector()
        {
            Color c1 = new Color();
            Color c2 = new Color();
            Color c3 = new Color();
            Color c4 = new Color();
            for (int y = 0; y < m_Bitmap.Height; y++)
            {
                for (int x = 0; x < m_Bitmap.Width; x++)
                {
                    c1 = GetPixel(x, y);
                    if (x < m_Bitmap.Width)
                    {
                        c2 = GetPixel(x + 1, y);
                        if (y < m_Bitmap.Height)
                        {
                            c4 = GetPixel(x + 1, y + 1);
                        }
                    }
                    else
                    {
                        c2 = Color.FromArgb(0, 0, 0);
                    }
                    if (y < m_Bitmap.Height)
                        c3 = GetPixel(x, y + 1);
                    else
                    {
                        c3 = Color.FromArgb(0, 0, 0);
                        c4 = Color.FromArgb(0, 0, 0);
                    }
                    if ((c1.R / 255 + c2.R / 255 + c3.R / 255 + c4.R / 255) > 1)
                    {
                        SetPixel(x, y, Color.FromArgb(255, 0, 0));
                    }
                    else
                        SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            }
        }

        public void Robert(byte red, byte green, byte blue)
        {
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            int line = m_BitmapData.Stride;
            int offset = Offset();
            byte c1, c2, c3, c4, c5, c6, c7, c8, c9, g;
            ToGrayScale(255);
            for (int i = 0; i < total_size - 2 * line - 8; i += 4)
            {
                c1 = ImageBytes[i];
                c2 = ImageBytes[i + 4];
                c3 = ImageBytes[i + 8];
                c4 = ImageBytes[i + line];
                c5 = ImageBytes[i + line + 4];
                c6 = ImageBytes[i + line + 8];
                c7 = ImageBytes[i + 2 * line];
                c8 = ImageBytes[i + 2 * line + 4];
                c9 = ImageBytes[i + 2 * line + 8];
                g = (byte)(Math.Abs((c7 + 2 * c8 + c9) - (c1 + 2 * c2 + c3))
                    + Math.Abs((c3 + 2 * c6 + c9) - (c1 + 2 * c4 + c7)));
                if (g > offset)
                {
                    ImageBytes[i] = blue;
                    ImageBytes[i + 1] = green;
                    ImageBytes[i + 2] = red;
                    ImageBytes[i + 3] = 255;
                }
            }
        }

        public void Gradient(byte opt)
        {
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            int line = m_BitmapData.Stride;
            byte c1, c2, c3;
            byte g;
            for (int i = 0; i < total_size - line - 4; i += 4)
            {
                c1 = ImageBytes[i];
                c2 = ImageBytes[i + 4];
                c3 = ImageBytes[i + line];
                g = (byte)(Math.Abs(c2 - c1) + Math.Abs(c3 - c1));
                if (g != 1 && g != 0)
                {
                    //ImageBytes[i] = c1; ;
                    //ImageBytes[i + 1] = c1;
                    ImageBytes[i + 2] = 255;
                    ImageBytes[i + 3] = opt;
                }
            }
        }

        public int IntergnalImage(int x, int y)
        {
            int total_size = 4 * x * y;
            int line = m_BitmapData.Stride;
            int sum = 0;
            ToGrayScale(255);
            for (int i = 0; i < total_size - 4; i += 4)
            {
                sum += ImageBytes[i];
            }
            return sum;
        }
        #endregion

        #region TACH BIEN
        public Point BotPoint()
        {
            Point p = new Point();
            Color c = new Color();
            int o = Offset();
            for (int y = 0; y < m_Bitmap.Height; y++)
            {
                for (int x = 0; x < m_Bitmap.Width; x++)
                {
                    c = GetPixel(x, y);
                    //if ((c.R == 255) && (c.G == 255) && (c.B == 255))
                    if ((c.R > o) && (c.G > o) && (c.B > o))
                    {
                        p.X = x;
                        p.Y = y;
                        break;
                    }
                }
            }
            return p;
        }

        public Point TopPoint()
        {
            Point p = new Point();
            Color c = new Color();
            int o = Offset();
            for (int y = m_Bitmap.Height; y >= 0; y--)
            {
                for (int x = 0; x < m_Bitmap.Width; x++)
                {
                    c = GetPixel(x, y);
                    //if ((c.R == 255) && (c.G == 255) && (c.B == 255))
                    if ((c.R > o) && (c.G > o) && (c.B > o))
                    {
                        p.X = x;
                        p.Y = y;
                        break;
                    }
                }
            }
            return p;
        }

        public Point RightPoint()
        {
            Point p = new Point();
            Color c = new Color();
            int o = Offset();
            for (int x = 0; x < m_Bitmap.Width; x++)
            {
                for (int y = 0; y < m_Bitmap.Height; y++)
                {
                    c = GetPixel(x, y);
                    //if ((c.R == 255) && (c.G == 255) && (c.B == 255))
                    if ((c.R > o) && (c.G > o) && (c.B > o))
                    {
                        p.X = x;
                        p.Y = y;
                        break;
                    }
                }
            }
            return p;
        }

        public Point LeftPoint()
        {
            Point p = new Point();
            Color c = new Color();
            int o = Offset();
            for (int x = m_Bitmap.Width; x >= 0; x--)
            {
                for (int y = 0; y < m_Bitmap.Height; y++)
                {
                    c = GetPixel(x, y);
                    //if ((c.R == 255) && (c.G == 255) && (c.B == 255))
                    if ((c.R > o) && (c.G > o) && (c.B > o))
                    {
                        p.X = x;
                        p.Y = y;
                        break;
                    }
                }
            }
            return p;
        }

        public void Compass(int x, int y)
        {
            Point curr = new Point(x, y);
            Color c = GetPixel(curr.X, curr.Y);
            Point[] p = {
                new Point(x - 1, y - 1),
                new Point(x, y - 1),
                new Point(x + 1, y - 1),
                new Point(x + 1, y),
                new Point(x + 1, y + 1),
                new Point(x, y + 1),
                new Point(x - 1, y + 1),
                new Point(x - 1, y)
            };
            if ((c.R == 0) && (curr.X < m_Bitmap.Width) && (curr.Y < m_Bitmap.Height) && (curr.X > 0) && (curr.Y > 0))
            {
                SetPixel(x, y, Color.Yellow);
                Compass(p[0].X, p[0].Y);
                Compass(p[1].X, p[1].Y);
                Compass(p[2].X, p[2].Y);
                Compass(p[3].X, p[3].Y);
                Compass(p[4].X, p[4].Y);
                Compass(p[5].X, p[5].Y);
                Compass(p[6].X, p[6].Y);
                Compass(p[7].X, p[7].Y);
            }
        }
        #endregion
    }
}