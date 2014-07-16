namespace SecurityProject_2014.Steganography
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MathWorks.MATLAB.NET.Arrays;
    using MathWorks.MATLAB.NET.Utility;
    using SteganographyMatlab;
    using System.IO;


    class AESSteg : IEncryption
    {
        #region Attributes
        private MWNumericArray SboxDec;
        private MWNumericArray SboxInv;
        private MWNumericArray Rcon;
        private MWNumericArray CipherKey;
        private MWNumericArray MatMixCol;
        private MWNumericArray MatMixColInv;
        private SteganographyMatlab.AES aesMatObj;
        private string srcStr = Path.GetDirectoryName(Path.GetDirectoryName(
                    System.IO.Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase))) + @"\Steganography\AESMatlab\mat\";
        #endregion 

        #region Methods
        private void Init()
        {
            string removeString = "file:\\";
            int i = this.srcStr.IndexOf(removeString);
            this.srcStr = (i < 0)
                                ? this.srcStr
                                : this.srcStr.Remove(i, removeString.Length);
            this.aesMatObj = new SteganographyMatlab.AES();

            this.SboxDec = (MWNumericArray)this.aesMatObj.loadmatfile((MWArray)this.srcStr + "SboxDec.mat");
            this.SboxInv = (MWNumericArray)this.aesMatObj.loadmatfile((MWArray)this.srcStr + "SboxInv.mat");
            this.Rcon = (MWNumericArray)this.aesMatObj.loadmatfile((MWArray)this.srcStr + "RconDec.mat");
            this.MatMixCol = (MWNumericArray)this.aesMatObj.loadmatfile((MWArray)this.srcStr + "MatMixColDec.mat");
            this.MatMixColInv = (MWNumericArray)this.aesMatObj.loadmatfile((MWArray)this.srcStr + "MatMixColInv.mat");
        }

        public AESSteg()
        {
            this.Init();
            this.CipherKey = (MWNumericArray)this.aesMatObj.loadmatfile((MWArray)this.srcStr + "CipherKeyDec");
        }

        public AESSteg(string CipherKeyPath)
        {
            this.Init();
            this.CipherKey = (MWNumericArray)this.aesMatObj.loadmatfile((MWArray)CipherKeyPath);
        }

        public AESSteg(double[,] CipherKey)
        {
            this.Init();
            this.CipherKey = (MWNumericArray)CipherKey;
        }

        public AESSteg(MWNumericArray CipherKey)
        {
            this.Init();
            this.CipherKey = CipherKey;
        }

        //private string FromChars(char[,] chars)
        //{
        //    string str = "";
        //    char c;
        //    for (int i = 0; i < chars.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < chars.GetLength(1); j++) 
        //        {
        //            c = chars[i, j];
        //            if (chars[i, j] == '"')
        //                str += "\"";
        //             else
        //                 str += chars[i, j];
        //        }
        //    }
        //    return str;
        //}
       

        public char[] Encrypt(string plaintext)
        {
            MWArray ciphertext = (MWArray)this.aesMatObj.AESEncrypt((MWArray)plaintext, CipherKey, SboxDec, Rcon, MatMixCol);
            char[,] ctchars = (char[,])ciphertext.ToArray();
            char[] chars = MatricesFactory.To1D(ctchars);
            
            return chars;
        }

        public char[] Decrypt(char[] ciphertext)
        {
            double[] ciphervector = BitManipulator.CharToDouble(ciphertext);
            //MWArray[] mw = this.aesMatObj.AESDecrypt(2, (MWNumericArray)(MatricesFactory.To2D(ciphervector)), CipherKey, SboxDec, SboxInv, Rcon, MatMixColInv);
            //MWNumericArray mn = (MWNumericArray)mw[1];
            MWArray plaintext = (MWArray)this.aesMatObj.AESDecrypt((MWNumericArray)(MatricesFactory.To2D(ciphervector)), CipherKey, SboxDec, SboxInv, Rcon, MatMixColInv);
            char[,] plaintextchars = (char[,])plaintext.ToArray();

            return MatricesFactory.To1D(plaintextchars);
        }

        public void SetCipherKey(double[,] cipherkey)
        {
            this.CipherKey = (MWNumericArray)cipherkey;
        }
        #endregion
    }
}
