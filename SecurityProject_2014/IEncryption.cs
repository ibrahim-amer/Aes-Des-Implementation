using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProject_2014
{
    interface IEncryption
    {
        char[] Encrypt(string plaintext);
        char[] Decrypt(char[] ciphertext);
    }
}
