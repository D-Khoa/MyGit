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
                c = (byte)(ImageBytes[i] * 0.11 + ImageBytes[i + 1] * 0.59 + ImageBytes[i + 2] * 0.3);
                ImageBytes[i] = c;
                ImageBytes[i + 1] = c;
                ImageBytes[i + 2] = c;
                ImageBytes[i + 3] = opt;
            }
        }

        public void ToBlackWhite(byte offset)
        {
            ToGrayScale(255);
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            for (int i = 0; i < total_size - 4; i += 4)
            {
                if (ImageBytes[i] > offset)
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

        public void Vector(byte opt)
        {
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            int line = m_BitmapData.Stride;
            byte c;
            byte t, l, r, b;
            ToGrayScale(0);
            for (int i = 4 + line; i < total_size - line - 4; i += 4)
            {
                c = (byte)(ImageBytes[i] * 0.11 + ImageBytes[i + 1] * 0.59 + ImageBytes[i + 2] * 0.3);
                t = (byte)(ImageBytes[i - line] * 0.11 + ImageBytes[i + 1 - line] * 0.59 + ImageBytes[i + 2 - line] * 0.3);
                b = (byte)(ImageBytes[i + line] * 0.11 + ImageBytes[i + 1 + line] * 0.59 + ImageBytes[i + 2 + line] * 0.3);
                l = (byte)(ImageBytes[i - 4] * 0.11 + ImageBytes[i - 3] * 0.59 + ImageBytes[i - 2] * 0.3);
                r = (byte)(ImageBytes[i + 4] * 0.11 + ImageBytes[i + 5] * 0.59 + ImageBytes[i + 6] * 0.3);
                if (c > t && c > b && c > r && c > l)
                {
                    ImageBytes[i] = 0;
                    ImageBytes[i + 1] = 0;
                    ImageBytes[i + 2] = 255;
                    ImageBytes[i + 3] = 255;
                }
            }
        }

        public void Robert(byte offset, byte red, byte green, byte blue)
        {
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            int line = m_BitmapData.Stride;
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

        public byte[] ToHex(int x, int y)
        {
            ToGrayScale(255);
            int total_size = m_BitmapData.Stride * m_BitmapData.Height;
            int n = 0;
            byte c;
            byte[] h = new byte[x * y];
            for (int i = 0; i < total_size - 4; i += 4)
            {
                c = ImageBytes[i];
                h[n] = Encoding.ASCII.GetBytes(c.ToString("X"));
                n++;
            }
            return h;
        }
    }
}
