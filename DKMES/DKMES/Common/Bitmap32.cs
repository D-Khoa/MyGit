using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

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
    }
}
