using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProject_2014.Steganography
{
    class DES : IEncryption
    {
        #region Attributes
        private bool[][] blocks;
        private bool[] key;
        private bool[][] allKeys;
        private int[] PC1 = {57, 49, 41, 33, 25, 17, 9, 
                            1, 58, 50, 42, 34, 26, 18,
                            10, 2, 59, 51, 43, 35, 27,
                            19, 11, 3, 60, 52, 44, 36,
                            63, 55, 47, 39, 31, 23, 15,
                            7, 62, 54, 46, 38, 30, 22,
                            14, 6, 61, 53, 45, 37, 29,
                            21, 13, 5, 28, 20, 12, 4
                            };
        private int[] PC2 = {14, 17, 11, 24, 1, 5,
                            3, 28, 15, 6, 21, 10,
                            23, 19, 12, 4, 26, 8,
                            16, 7, 27, 20, 13, 2,
                            41, 52, 31, 37, 47, 55,
                            30, 40, 51, 45, 33, 48,
                            44, 49, 39, 56, 34, 53,
                            46, 42, 50, 36, 29, 32
                           };
        private int[] IP = {58, 50, 42, 34, 26, 18, 10, 2,
                            60, 52, 44, 36, 28, 20, 12, 4,
                            62, 54, 46, 38, 30, 22, 14, 6,
                            64, 56, 48, 40, 32, 24, 16, 8,
                            57, 49, 41, 33, 25, 17, 9, 1,
                            59, 51, 43, 35, 27, 19, 11, 3,
                            61, 53, 45, 37, 29, 21, 13, 5,
                            63, 55, 47, 39, 31, 23, 15, 7
                            };
        private int[] IP1 = { 40, 8, 48, 16, 56, 24, 64, 32,
                            39, 7, 47, 15, 55, 23, 63, 31,
                            38, 6, 46, 14, 54, 22, 62, 30,
                            37, 5, 45, 13, 53, 21, 61, 29,
                            36, 4, 44, 12, 52, 20, 60, 28,
                            35, 3, 43, 11, 51, 19, 59, 27,
                            34, 2, 42, 10, 50, 18, 58, 26,
                            33, 1, 41, 9, 49, 17, 57, 25
                            };
        private int[] ETable = {32, 1, 2, 3, 4, 5,
                                4, 5, 6, 7, 8, 9,
                                8, 9, 10, 11, 12, 13,
                                12, 13, 14, 15, 16, 17,
                                16, 17, 18, 19, 20, 21,
                                20, 21, 22, 23, 24, 25,
                                24, 25, 26, 27, 28, 29,
                                28, 29, 30, 31, 32, 1
                                };
        private int[] P = { 16, 7, 20, 21,
                            29, 12, 28, 17,
                            1, 15, 23, 26,
                            5, 18, 31, 10,
                            2, 8, 24, 14,
                            32, 27, 3, 9,
                            19, 13, 30, 6,
                            22, 11, 4, 25 
                          };
        private int[] LCS = { 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1 };

        private int[,] s1 = {{14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7},
                             {0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8},
                             {4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0},
                             {15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13}
                             };
        private int[,] s2 = {{15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10},
                             {3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5},
                             {0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15},
                             {13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9}
                            };
        private int[,] s3 = {{10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8},
                             {13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1},
                             {13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7},
                             {1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12}
                            };
        private int[,] s4 = {{7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15},
                             {13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9},
                             {10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4},
                             {3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14}
                            };
        private int[,] s5 = {{2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9},
                             {14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6},
                             {4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14},
                             {11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3}
                            };
        private int[,] s6 = {{12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11},
                             {10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8},
                             {9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6},
                             {4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13}
                            };
        private int[,] s7 = {{4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1},
                             {13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6},
                             {1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2},
                             {6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12}
                            };
        private int[,] s8 = {{13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7},
                             {1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2},
                             {7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8},
                             {2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11}
                            };
        private List<int[,]> sboxes;
        #endregion
        #region Constructor
        public DES(string key)
        {
            this.key = BitManipulator.StringToBinary(key);
            this.allKeys = new bool[16][];
            this.sboxes = new List<int[,]>();
            this.sboxes.Add(s1);
            this.sboxes.Add(s2);
            this.sboxes.Add(s3);
            this.sboxes.Add(s4);
            this.sboxes.Add(s5);
            this.sboxes.Add(s6);
            this.sboxes.Add(s7);
            this.sboxes.Add(s8);
            this.GenerateKeys();

        }


        #endregion
        #region Functions
        private bool[] Permutation(int[] P, bool[] data)
        {
            bool[] ret = new bool[P.Length];
            for (int i = 0; i < P.Length; i++)
            {
                ret[i] = data[P[i] - 1];
            }
            return ret;
        }

        public void GenerateKeys()
        {
            bool[] keyPc1 = this.Permutation(this.PC1, this.key);
            bool[] roundkey = keyPc1;
            bool[] C = new bool[28];
            bool[] D = new bool[28];
            bool[] keyPc2;
            for (int i = 0; i < 16; i++)
            {
                Array.Copy(roundkey, 0, C, 0, C.Length);
                Array.Copy(roundkey, 28, D, 0, D.Length);
                C = BitManipulator.LCS(this.LCS[i], C);
                D = BitManipulator.LCS(this.LCS[i], D);
                Array.Copy(C, 0, roundkey, 0, C.Length);
                Array.Copy(D, 0, roundkey, C.Length, D.Length);
                keyPc2 = this.Permutation(this.PC2, roundkey);
                this.allKeys[i] = keyPc2;
            }
        }

        public char[] Encrypt(string plaintext)
        {
            return this.Encryption(plaintext);
        }

        public char[] Decrypt(char[] ciphertext)
        {
            return this.Decryption(ciphertext).ToCharArray();
        }

        private char[] Encryption(string Msg)
        {
            this.SetBlocksOfPlainText(Msg);
            bool[] msgtIP;
            bool[] LHalf = new bool[32];
            bool[] RHalf = new bool[32];
            bool[] REtable;
            bool[] inpXORmsg;
            bool[] sboxOutput = new bool[32];
            bool[] sboxCellInput = new bool[6];
            bool[] sboxP;
            bool[] RXorL = null;
            bool[] encyMsg = new bool[64];
            bool[] encyMsgP = new bool[64];
            byte[] encyMsgByte;
            char[] encyMsgChar = new char[this.blocks.GetLength(0) * 8];
            for (int i = 0; i < this.blocks.GetLength(0); i++)
            {
                msgtIP = this.Permutation(this.IP, this.blocks[i]);
                Array.Copy(msgtIP, 0, LHalf, 0, LHalf.Length);
                Array.Copy(msgtIP, LHalf.Length, RHalf, 0, RHalf.Length);
                for (int j = 0; j < 16; j++)
                {
                    REtable = this.Permutation(this.ETable, RHalf);
                    inpXORmsg = BitManipulator.XOR(REtable, this.allKeys[j]);

                    for (int k = 0, l = 0; k < inpXORmsg.Length; k += 6, l++)
                    {
                        Array.Copy(inpXORmsg, k, sboxCellInput, 0, sboxCellInput.Length);
                        bool[] temp = this.Sbox(sboxCellInput, this.sboxes[l]);
                        Array.Copy(temp, 0, sboxOutput, 4 * l, 4);
                    }
                    sboxP = this.Permutation(this.P, sboxOutput);
                    RXorL = BitManipulator.XOR(sboxP, LHalf);
                    LHalf = RHalf;
                    RHalf = RXorL;
                }
                RHalf = LHalf;
                LHalf = RXorL;
                Array.Copy(LHalf, 0, encyMsg, 0, LHalf.Length);
                Array.Copy(RHalf, 0, encyMsg, LHalf.Length, RHalf.Length);
                encyMsgP = this.Permutation(this.IP1, encyMsg);
                encyMsgByte = BitManipulator.BoolToByte(encyMsgP);
                Array.Copy(this.ToCharArray(encyMsgByte), 0, encyMsgChar, i * 8, 8);
            }

            return encyMsgChar;
        }

        private char[] ToCharArray(byte[] data)
        {
            char[] ret = new char[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                ret[i] = (char)data[i];
            }
            return ret;
        }


        private string Decryption(char[] encyptedMessage)
        {
            string OriginalMessage = "";
            this.SetBlocksOfencyptedMessage(encyptedMessage);
            bool[] msgtIP;
            bool[] LHalf = new bool[32];
            bool[] RHalf = new bool[32];
            bool[] REtable;
            bool[] inpXORmsg;
            bool[] sboxOutput = new bool[32];
            bool[] sboxCellInput = new bool[6];
            bool[] sboxP;
            bool[] RXorL = null;
            bool[] encyMsg = new bool[64];
            bool[] encyMsgP = new bool[64];
            byte[] encyMsgByte;
            for (int i = 0; i < this.blocks.GetLength(0); i++)
            {
                msgtIP = this.Permutation(this.IP, this.blocks[i]);
                Array.Copy(msgtIP, 0, LHalf, 0, LHalf.Length);
                Array.Copy(msgtIP, LHalf.Length, RHalf, 0, RHalf.Length);
                for (int j = 0; j < 16; j++)
                {
                    REtable = this.Permutation(this.ETable, RHalf);
                    inpXORmsg = BitManipulator.XOR(REtable, this.allKeys[16 - j - 1]);

                    for (int k = 0, l = 0; k < inpXORmsg.Length; k += 6, l++)
                    {
                        Array.Copy(inpXORmsg, k, sboxCellInput, 0, sboxCellInput.Length);
                        bool[] temp = this.Sbox(sboxCellInput, this.sboxes[l]);
                        Array.Copy(temp, 0, sboxOutput, 4 * l, 4);
                    }
                    sboxP = this.Permutation(this.P, sboxOutput);
                    RXorL = BitManipulator.XOR(sboxP, LHalf);
                    LHalf = RHalf;
                    RHalf = RXorL;
                }
                RHalf = LHalf;
                LHalf = RXorL;
                Array.Copy(LHalf, 0, encyMsg, 0, LHalf.Length);
                Array.Copy(RHalf, 0, encyMsg, LHalf.Length, RHalf.Length);
                encyMsgP = this.Permutation(this.IP1, encyMsg);
                encyMsgByte = BitManipulator.BoolToByte(encyMsgP);
                Array.Reverse(encyMsgByte);
                OriginalMessage += Encoding.ASCII.GetString(encyMsgByte);
            }

            return OriginalMessage;
        }

        private bool[] Sbox(bool[] sboxCellInput, int[,] sbox)
        {
            bool[] rowInBool = { sboxCellInput[0], sboxCellInput[5] };
            bool[] colInBool = { sboxCellInput[1], sboxCellInput[2], sboxCellInput[3], sboxCellInput[4] };
            byte[] rowInByte = BitManipulator.BoolToByte(rowInBool);
            byte[] colInByte = BitManipulator.BoolToByte(colInBool);
            int row = (int)(Convert.ToDecimal(rowInByte[0]));
            int col = (int)(Convert.ToDecimal(colInByte[0]));
            int temp = sbox[row, col];
            byte[] b = BitManipulator.IntTobytes(temp);
            bool[] sboxCellOutput = new bool[4]; 
            Array.Copy(BitManipulator.GetMasks(b).ToArray(), 28, sboxCellOutput, 0, 4);
            return sboxCellOutput;
        }

        private void SetBlocksOfPlainText(string secretMsg)
        {
            bool[] secretMsgBits = BitManipulator.StringToBinary(secretMsg);
            int numOfBlocks = secretMsgBits.Length / 64;
            numOfBlocks = (secretMsgBits.Length % 64 != 0) ? ++numOfBlocks : numOfBlocks;
            blocks = new bool[numOfBlocks][];
            bool[] block = new bool[64];
            int i, j = 0, count = 0;
            /////Padding & Block Division
            for (i = 0; i < secretMsgBits.Length && j < numOfBlocks; i++)
            {
                if (count == 63)
                {
                    block[count] = secretMsgBits[i];
                    blocks[j] = block;
                    block = new bool[64];
                    j++;
                    count = 0;
                }
                else
                {
                    block[count] = secretMsgBits[i];
                    ++count;
                    if (i == secretMsgBits.Length - 1)
                        blocks[j] = block;
                }
            }
            if (count != 0)
            {
                for (int k = count; k < 64; k++)
                {
                    blocks[j][k] = false;
                }
            }
        }

        private void SetBlocksOfencyptedMessage(char[] encyptedMessage)
        {
            int numOfBlock = encyptedMessage.Length / 8;
            this.blocks = new bool[numOfBlock][];
            byte[] MsgByte = new byte[8];
            for (int i = 0; i < numOfBlock; i++)
            {
                for (int j = 0; j < MsgByte.Length; j++)
                {
                    MsgByte[j] = (byte)encyptedMessage[j + (i * 8)];
                }
                Array.Reverse(MsgByte);
                this.blocks[i] = (BitManipulator.GetMasks(MsgByte)).ToArray();
            }
        }

        #endregion

    }
}
