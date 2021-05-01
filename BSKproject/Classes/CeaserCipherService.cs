using System;
using System.Collections.Generic;
using System.Text;

namespace BSKproject.Classes
{
    public class CeaserCipherService
    {
        public string Encode(string word, int k0, int k1)
        {
            word = word.ToUpper();
            int n = 26;
            char charChiper;
            int A = 65;
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                charChiper = (char)(((((int)word[i] - A) * k0) + k1) % n + A);
                result += charChiper;
            }
            return result;
        }

        public string Decode(string word, int k0, int k1)
        {
            word = word.ToUpper();
            int n = 26;
            char charChiper;
            int euler = 12;
            int A = 65;
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                charChiper = (char)(((((int)word[i] - A) + (n - k1)) * (Math.Pow(k0, euler - 1))) % n + A);
                result += charChiper;
            }
            return result;
        }

    }
}
