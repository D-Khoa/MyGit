﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject.Common
{
    public class BaseGraphics
    {
        public BaseGraphics(Image inputImage, int col, int row)
        {
            img = inputImage;
            width = img.Width;
            height = img.Height;
            total_frames = col * row;
            getFrames(col, row);
        }

        public Image img { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int total_frames { get; set; }
        public List<Image> Frames { get; set; }

        //CHECK IMG CAN BECOME SPRITE
        public bool is_Sprite()
        {
            if (total_frames > 0)
                return ((width * height) % total_frames == 0);
            else return false;
        }

        //GET LIST FRAMES FROM SPRITE
        public void getFrames(int c, int r)
        {
            if (is_Sprite())
            {
                //List<Rectangle> list_of_rects = new List<Rectangle>();
                Frames = new List<Image>();
                int w = width / c;
                int h = height / r;
                for (int i = 0; i < total_frames; i++)
                {
                    //list_of_rects.Add(new Rectangle((i % c) * w, (i / c) * h, w, h));
                    Frames.Add(new Bitmap(img).Clone(new Rectangle((i % c) * w, (i / c) * h, w, h), img.PixelFormat));
                }
            }
        }
    }
}
