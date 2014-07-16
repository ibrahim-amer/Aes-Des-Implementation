using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProject_2014
{
    static class MatricesFactory
    {
        public static char[] To1D(char[,] chars)
        {
            char[] chars1d = new char[chars.GetLength(1)];
            char c;
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    chars1d[j] = chars[i, j];
                }
            }
            return chars1d;
        }

        public static char[,] To2D(char[] chars)
        {
            char[,] ret = new char[1, chars.Length];
            for (int i = 0; i < chars.Length; i++) ret[0, i] = chars[i];
            return ret;
        }

        public static double[,] To2D(double[] doubles)
        {
            double[,] ret = new double[1, doubles.Length];
            for (int i = 0; i < doubles.Length; i++) ret[0, i] = doubles[i];
            return ret;
        }

        public static int[,] To2D(int[] ints)
        {
            int[,] ret = new int[1, ints.Length];
            for (int i = 0; i < ints.Length; i++) ret[0, i] = ints[i];
            return ret;
        }
    }
}
