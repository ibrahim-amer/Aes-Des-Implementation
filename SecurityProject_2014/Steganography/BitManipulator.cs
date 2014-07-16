namespace SecurityProject_2014.Steganography
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    static class BitManipulator
    {
        static public bool GetBit(byte b, int bitnum)
        {
            return (b & (1 << bitnum - 1)) != 0;
        }
        static public bool GetBit(int b, int bitnum)
        {
            return (b & (1 << bitnum - 1)) != 0;
        }
        static public List<bool> GetMasks(byte[] msgSizeInBytes)
        {
            List<bool> masks = new List<bool>();
            for (int i = 0; i < msgSizeInBytes.Length; i++)
            {
                for (int j = 8; j >= 1; j--)
                {
                    masks.Add(GetBit(msgSizeInBytes[i], j));
                }
            }

            return masks;
        }
        static public byte[] BoolToByte(bool[] bools)
        {
            Array.Reverse(bools);
            int bytes = bools.Length / 8;
            if ((bools.Length % 8) != 0) bytes++;
            byte[] arr2 = new byte[bytes];
            int bitIndex = 0, byteIndex = 0;
            for (int i = 0; i < bools.Length; i++)
            {
                if (bools[i])
                {
                    arr2[byteIndex] |= (byte)(((byte)1) << bitIndex);
                }
                bitIndex++;
                if (bitIndex == 8)
                {
                    bitIndex = 0;
                    byteIndex++;
                }
            }
            return arr2;
        }
        //
        static public int[] BoolToInt(bool[] bools)
        {
            Array.Reverse(bools);
            int bytes = bools.Length / 32;
            if ((bools.Length % 32) != 0) bytes++;
            int[] arr2 = new int[bytes];
            int bitIndex = 0, byteIndex = 0;
            for (int i = 0; i < bools.Length; i++)
            {
                if (bools[i])
                {
                    arr2[byteIndex] |= (int)(((int)1) << bitIndex);
                }
                bitIndex++;
                if (bitIndex == 32)
                {
                    bitIndex = 0;
                    byteIndex++;
                }
            }
            return arr2;
        }
        //
        public static List<bool> StrToBits(string str)
        {
            int[] charint = new int[str.Length];
            for (int i = 0; i < str.Length; i++) charint[i] = (int)str[i];
            List<bool> bits = new List<bool>();
            for (int i = 0; i < charint.Length; i++)
            {
                for (int j = 32; j >= 1; j--)
                {
                    bits.Add(GetBit(charint[i], j));
                }
            }
            return bits;
        }
        public static List<bool> CharsToBits(char[] chars)
        {
            byte[] charint = new byte[chars.Length];
            for (int i = 0; i < charint.Length; i++) charint[i] = (byte)chars[i];
            List<bool> bits = new List<bool>();
            for (int i = 0; i < charint.Length; i++)
            {
                for (int j = 8; j >= 1; j--)
                {
                    bits.Add(GetBit(charint[i], j));
                }
            }
            return bits;
        }
        //
        public static List<bool> IntToBits(int n)
        {
            List<bool> bits = new List<bool>();
            for (int j = 32; j >= 1; j--)
            {
                bits.Add(GetBit(n, j));
            }
            return bits;
        }
        //
        public static char[] IntsToChar(int []ints)
        {
            char[] chars = new char[ints.Length];
            for (int i = 0; i < ints.Length; i++) chars[i] = (char)ints[i];
            return chars;
        }

        public static int[] CharsToInts(char[] chars)
        {
            int[] ints = new int[chars.Length];
            for (int i = 0; i < ints.Length; i++) ints[i] = (int)chars[i];
            return ints;
        }

        public static double[] CharToDouble(char[] chars)
        {
            double[] doubles = new double[chars.Length];
            for (int i = 0; i < doubles.Length; i++) doubles[i] = (int)chars[i];
            return doubles;
        }

        public static byte[] FromHex(string hex)
        {
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }

        public static bool[] LCS(int shiftAmount, bool[] data)
        {
            bool[] ret = new bool[data.Length];
            bool[] shiftedBits = new bool[shiftAmount];
            Array.Copy(data, shiftedBits, shiftAmount);
            for (int i = 0; i < data.Length - shiftAmount; i++)
            {
                ret[i] = data[i + shiftAmount];
            }
            Array.Copy(shiftedBits, 0, ret, data.Length - shiftAmount, shiftAmount);
            return ret;
        }

        public static bool[] StringToBinary(string s)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            bool[] bits = GetMasks(bytes).ToArray();
            return bits;
        }

        public static bool[] XOR(bool[] data1, bool[] data2)
        {
            bool[] ret = new bool[data1.Length];
            for (int i = 0; i < data1.Length; i++)
            {
                ret[i] = data1[i] ^ data2[i];
            }
            return ret;
        }

        public static byte[] IntTobytes(int intValue)
        {
            byte[] intBytes = BitConverter.GetBytes(intValue);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(intBytes);
            byte[] result = intBytes;
            return result;
        }

        public static bool[] HexToBits(string hex)
        {
            bool[] ret;
            byte[] toByte = BitManipulator.FromHex(hex);
            ret = (BitManipulator.GetMasks(toByte)).ToArray();
            return ret;
        }

        public static char[] BytesToChars(byte[] bytes)
        {
            char[] chars = new char[bytes.Length];
            for (int i = 0; i < chars.Length; i++) chars[i] = (char)bytes[i];
            return chars;
        }
    }
}
