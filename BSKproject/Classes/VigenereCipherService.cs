using System;
using System.Collections.Generic;
using System.Text;

namespace BSKproject.Classes
{
    public class VigenereCipherService
    {
        public string Encode(string word, string key)
        {

            char[,] tab = new char[26, 26];
            string result = "";
            int A = 65;
            int n = 26;          
            int charAscii = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tab[i, j] = (char)(charAscii + A);
                    charAscii = (charAscii + 1) % n;
                }
                charAscii = (charAscii + 1) % n;
            }
            int row;
            int column;
            for (int i = 0; i < word.Length; i++)
            {
                row = (int)word[i] - A;
                column = (int)key[i % key.Length] - A;
                result += tab[column, row];
            }
            return result;

        }
        public string Decode(string word, string key)
        {

            char[,] tab = new char[26, 26];
            string result = "";
            int A = 65;
            int n = 26;
            int charAscii = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tab[i, j] = (char)(charAscii + A);
                    charAscii = (charAscii + 1) % n;
                }
                charAscii = (charAscii + 1) % n;
            }
            int row;
            int column;
            for (int i = 0; i < word.Length; i++)
            {
                row = 0;
                column = (int)key[i % key.Length] - A;
                while (tab[column, row] != word[i])
                {
                    row++;
                }
                result += tab[0, row];
            }
            return result;


        }
    }
}
