namespace SecurityProject_2014.Steganography
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text;

    class TextHider
    {
        public Bitmap bmp;
        private int w, h;
        public TextHider(Bitmap bmp)
	    {
           // this.buffer = new ImageBuffer(this.bmp, ImageBuffer.BufferType.Double);
            this.bmp = bmp;
	    }

       
        public int GetMsgSize()
        {
            List<bool> bits = new List<bool>();
            bool done = false;
            int count = 0;
            Color clr;
            int i = 0, j = 0;
            for (i = 0; i < bmp.Width; i++)
            {
                for (j = 0; j < bmp.Height; j++)
                {
                    clr = bmp.GetPixel(i, j);
                    if (count == 30)
                    {
                        bits.Add(BitManipulator.GetBit(clr.R, 1));
                        bits.Add(BitManipulator.GetBit(clr.G, 1));
                        done = true;
                        break;
                    }
                    else
                    {
                        clr = bmp.GetPixel(i, j);
                        bits.Add(BitManipulator.GetBit(clr.R, 1));
                        bits.Add(BitManipulator.GetBit(clr.G, 1));
                        bits.Add(BitManipulator.GetBit(clr.B, 1));
                        count += 3;
                    }
                }
                if (done)
                    break;
            }
            //byte[] bytes = BitManipulator.BoolToByte(bits.ToArray());
            this.w = i;
            this.h = j;
            return BitManipulator.BoolToInt(bits.ToArray())[0];
        }
        private Bitmap InsertMsgSize(int n)
        {
            //int msgSize = msg.Length;
            //byte[] msgSizeInBytes = BitConverter.GetBytes(msgSize);
            //if (BitConverter.IsLittleEndian)
            //    Array.Reverse(msgSizeInBytes);

            //List<bool> masks = BitManipulator.GetMasks(msgSizeInBytes);

            List<bool> masks = BitManipulator.IntToBits(n);
            //masks.Reverse();
            Color clr;
            bool done = false;
            byte m = 254;
            int k = 0, i = 0, j = 0;

            for (i = 0; i < this.bmp.Width && k < masks.Count; i++)
            {
                for (j = 0; j < this.bmp.Height && k < masks.Count; j++)
                {
                    if (k == masks.Count - 2)
                    {
                        clr = this.bmp.GetPixel(i, j);
                        clr = Color.FromArgb(clr.R & (byte)254,
                            clr.G & (byte)254, clr.B);

                        clr = Color.FromArgb(clr.R | Convert.ToByte(masks[k]),
                            clr.G | Convert.ToInt32(masks[k + 1]), clr.B);
                        this.bmp.SetPixel(i, j, clr);
                        done = true;
                        break;
                    }
                    else
                    {
                            
                        clr = this.bmp.GetPixel(i, j);
                        clr = Color.FromArgb(clr.R & (byte)254,
                            clr.G & (byte)254, clr.B & (byte)254);
                        clr = Color.FromArgb(clr.R | Convert.ToInt32(masks[k]),
                            clr.G | Convert.ToInt32(masks[k + 1]), clr.B | Convert.ToInt32(masks[k + 2]));
                        this.bmp.SetPixel(i, j, clr);
                        k += 3;
                    }
                }
                if (done)
                    break;
             }
            this.w = i;
            this.h = j;
            return bmp;
            
        }
        public Bitmap HideText(char[] chars)
        {
            List<bool> bits = BitManipulator.CharsToBits(chars);
            this.InsertMsgSize(chars.Length);
            return this.HideText(bits);
        }
        private Bitmap HideText(List<bool> masks)
        {
            int numOfPixels = masks.Count / 3, numOfBits = masks.Count;
            numOfPixels = (numOfPixels % 3) != 0 ? numOfPixels++ : numOfPixels;
            int k = 0;
            bool done = false;
            Color clr;
            for (int i = this.w; i < this.bmp.Width && k < masks.Count; i++)
            {
                for (int j = this.h + 1; j < this.bmp.Height && k < masks.Count; j++)
                {
                    clr = this.bmp.GetPixel(i, j);

                    if (numOfBits < 3)
                    {
                        if (numOfBits == 2)
                        {
                            clr = Color.FromArgb(clr.R & (byte)254,
                           clr.G & (byte)254, clr.B);
                            clr = Color.FromArgb(clr.R | Convert.ToInt32(masks[k]),
                            clr.G | Convert.ToInt32(masks[k + 1]), clr.B);
                        }
                        else if (numOfBits == 1)
                        {
                            clr = Color.FromArgb(clr.R & (byte)254,
                           clr.G, clr.B);
                            clr = Color.FromArgb(clr.R | Convert.ToInt32(masks[k]),
                                clr.G, clr.B);
                        }
                        done = true;
                        k += 3;
                        numOfBits -= 3;
                        this.bmp.SetPixel(i, j, clr);
                        break;
                    }
                    else
                    {
                        clr = Color.FromArgb(clr.R & (byte)254,
                            clr.G & (byte)254, clr.B & (byte)254);
                        clr = Color.FromArgb(clr.R | Convert.ToInt32(masks[k]),
                            clr.G | Convert.ToInt32(masks[k + 1]), clr.B | Convert.ToInt32(masks[k + 2]));
                        k += 3;
                        numOfBits -= 3;
                    }
                    this.bmp.SetPixel(i, j, clr);
                }
                if (done)
                    break;

            }
            return bmp;
        }
        public Bitmap HideText(string msg)
        {
            this.InsertMsgSize(msg.Length);
           // byte[] byteMsg = Encoding.ASCII.GetBytes(msg);
           // List<bool> masks = BitManipulator.GetMasks(byteMsg);
            List<bool> masks = BitManipulator.StrToBits(msg);
            return this.HideText(masks);
        }

        public char[] GetText()
        {
            string ret = "";
            int msgSize = this.GetMsgSize();
            int numOfBits = msgSize * 8;
            List<bool> bits = new List<bool>();
            byte[] bytes;
            Color clr = new Color();
            bool done = false;
            for (int i = this.w; i < this.bmp.Width; i++)
            {
                for (int j = this.h + 1; j < this.bmp.Height; j++)
                {
                    if (numOfBits < 3)
                    {
                        clr = this.bmp.GetPixel(i, j);
                        if (numOfBits == 2)
                        {
                            bits.Add(BitManipulator.GetBit(clr.R, 1));
                            bits.Add(BitManipulator.GetBit(clr.G, 1));
                        }
                        else if (numOfBits == 1)
                            bits.Add(BitManipulator.GetBit(clr.R, 1));
                        done = true;

                        numOfBits -= 3;
                        break;
                    }
                    else
                    {
                        clr = this.bmp.GetPixel(i, j);
                        bits.Add(BitManipulator.GetBit(clr.R, 1));
                        bits.Add(BitManipulator.GetBit(clr.G, 1));
                        bits.Add(BitManipulator.GetBit(clr.B, 1));
                        numOfBits -= 3;
                    }
                }
                if (done)
                    break;
            }
            //bytes = BitManipulator.BoolToByte(bits.ToArray());
            //char[] charArray = Encoding.ASCII.GetString(bytes).ToCharArray();
            //Array.Reverse(charArray);
            byte[] ints = BitManipulator.BoolToByte(bits.ToArray());
            //char[] chars = BitManipulator.IntsToChar(ints);
            char[] chars = BitManipulator.BytesToChars(ints);
            Array.Reverse(chars);
            return chars;
        }

        
    }
}
