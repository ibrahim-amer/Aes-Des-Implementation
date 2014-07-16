namespace SecurityProject_2014
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MathWorks.MATLAB.NET.Arrays;
    using MathWorks.MATLAB.NET.Utility;
    using System.Text.RegularExpressions;
    using SecurityProject_2014;
    static class UIHelperFunctions
    {

        public static MWNumericArray GetCipherKey(string key)
        {
            MWNumericArray ret = null;
            if (Regex.IsMatch(key, @"^[a-zA-Z]+$"))
            {
                ret = (MWNumericArray)Program.aesMatObj.loadmatfile((MWArray)key); ;
            }
            else
            {
                double[,] doubles = new double[4, 4];
                string[] cells = key.Split(' ');
                int count = -1;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        doubles[i, j] = double.Parse(cells[++count]);
                    }
                }

                ret = (MWNumericArray)doubles;
            }
            return ret;
        }
    }
}
