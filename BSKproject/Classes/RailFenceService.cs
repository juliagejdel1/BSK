using System;
using System.Collections.Generic;
using System.Text;

namespace BSKproject.Classes
{
    public class RailFenceService
    {
        public string Encode(string word, int key)
        {
            int row= 0;
            int column= 0;
            int change = -1;
            char[] ciphered = new char[word.Length];

            char[,] result = new char[key, word.Length];
           
            for (int i = 0; i < word.Length; i++)
            {
                result[row, column] = word[i];
                column++;
                if (row == 0 || row == key - 1)
                {
                    change *= -1;
                }
                row += change;
            }

            int z = 0;
            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (result[i, j] != '\0')
                    {
                        ciphered[z] = result[i, j];
                        z++;
                    }
                }
            }
            string cipheredWord = new string(ciphered);
            return cipheredWord;

        }
        public string Decode(string word, int key)
        {
            int row = 0;
            int column = 0;
            int z = 0;
            bool direction = true;
            char[] ciphered = new char[word.Length];
            char[,] result = new char[key, word.Length];


            for (int i = 0; i < word.Length; i++)
            {
                if (row == 0)
                    direction = true;
                if (row == key - 1)
                    direction = false;

                result[row, column] = '-';
                column++;

                if (direction)
                    row++;
                else
                    row--;
            }

            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (result[i, j] == '-')
                    {
                        result[i, j] = word[z];
                        z++;
                    }
                }
            }
            row = 0;
            column = 0;
          
            for (int i = 0; i < word.Length; i++)
            {
                if (row == 0)
                {
                    direction = true;
                }
                if (row == key - 1)
                {
                    direction = false;
                }
                if (result[row, column] != '\0')
                {
                    ciphered[i] = result[row, column];
                    column++;
                }
                if (direction)
                    row++;
                else
                    row--;
            }
            string cipheredWord = new string(ciphered);
            return cipheredWord;
        }
    }
}
