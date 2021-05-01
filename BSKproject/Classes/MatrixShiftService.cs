using System;
using System.Collections.Generic;
using System.Text;

namespace BSKproject.Classes
{
    public class MatrixShiftService
    {
        public string Encode(string word)
        {
            int row;
            var keyInt = new int[] { 3, 4, 1, 5, 2 };


            int index = 0;


            if (word.Length % keyInt.Length == 0)
            {
                row = word.Length / keyInt.Length;
            }
            else
            {
                row = word.Length / keyInt.Length + 1;
            }

            char[,] result = new char[row, keyInt.Length];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < keyInt.Length; j++)
                {
                    if (index < word.Length)
                        result[i, j] = word[index++];
                    else
                        result[i, j] = '-';
                }
            }

            string ciphered = "";
            for (int i = 0; i < row; i++)
            {
                foreach (var elem in keyInt)
                {
                    if (result[i, elem - 1] != '-')
                    {
                        ciphered += result[i, elem - 1];
                    }
                }
            }

            return ciphered;
        }
        public string Decode(string word)
        {
            int row;
            var keyInt = new int[] { 3, 4, 1, 5, 2 };


            int index = 0;

            if (word.Length % keyInt.Length == 0)
            {
                row = word.Length / keyInt.Length;
            }
            else
            {
                row = word.Length / keyInt.Length + 1;
            }
            int empty = row * keyInt.Length - word.Length;

            char[,] result = new char[row, keyInt.Length];

            for (int i = row-1; i > 0; i--)
            {
                for (int j = keyInt.Length-1; j > 0; j--)
                {
                    if (empty == 0)
                        break;
                    result[i, j] = '-';
                    empty--;
                }
            }
            for (int i = 0; i < row; i++)
            {
                foreach (var col in keyInt)
                {
                    if (index < word.Length)
                        if (result[i, col - 1] != '-')
                            result[i, col - 1] = word[index++];
                }
            }

            char znak;
            int k;
            index = 0;

            string ciphered = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < keyInt.Length; j++)
                {
                    if (result[i, j] == '-')
                        continue;
                    ciphered += result[i, j];
                }
            }

            return ciphered;



        }
    }
}
