using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProject_2014.Steganography
{
    class ImageBuffer
    {
        [Flags]
        public enum BufferType
        {
            Double,
            Byte,
            RGBColor
        }
        public RGBDouble[,] DoubleBuffer;
        Bitmap bmp;
        public struct RGBDouble
        {
            public double R, G, B;
            public RGBDouble(double R, double G, double B)
            {
                this.R = R;
                this.B = B;
                this.G = G;
            }
        }
        public ImageBuffer(Bitmap bmp, BufferType type)
        {
            if (type == BufferType.Double)
            {
                this.bmp = bmp;
                this.CreateDoubleBuffer(bmp);
            }
        }

        public RGBDouble[,] CreateDoubleBuffer(Bitmap bmp)
        {
            this.DoubleBuffer = new RGBDouble[bmp.Height, bmp.Width];
            Color clr;
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    clr = bmp.GetPixel(j, i);
                    this.DoubleBuffer[i, j].R = (double)clr.R;
                    this.DoubleBuffer[i, j].G = (double)clr.G;
                    this.DoubleBuffer[i, j].B = (double)clr.B;
                }
            }

            return this.DoubleBuffer;
        }

        public Bitmap ToBitmap(RGBDouble[,] buffer)
        {
            Bitmap ret = new Bitmap(buffer.GetLength(2), buffer.GetLength(1));
            Color clr = new Color();
            for (int i = 0; i < ret.Width; i++)
            {
                for (int j = 0; j < ret.Height; j++)
                {
                    clr = Color.FromArgb((int)buffer[j, i].R,
                    (int)buffer[j, i].G,
                    (int)buffer[j, i].B);
                    ret.SetPixel(i, j, clr);
                }
            }
            return ret;
        }



    }
}
