using System;
using System.Collections.Generic;
using System.Text;

namespace BSKproject.Classes
{
    public class Matrix2bService
    {
        public string Encode(string word, string key)
        {
            int row;
            int column;
            int index = 0;        
            string password = "";

         
            if (word.Length % key.Length == 0)
                row = word.Length / key.Length;
            else
                row = word.Length / key.Length + 1;

            column = key.Length;
            char[,] tab = new char[row, column];

            for (int a = 0; a < word.Length; a++)
            {
                if (word[a] != ' ')
                    password += word[a];
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (password.Length - 1 >= index)
                    {
                        tab[i, j] = password[index];
                    }
                    else
                        tab[i, j] = '-';
                    index++;
                }
            }
            string result = "";
            for (int i = 65; i < 91; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if ((int)key[j] == i)
                    {
                        for (int k = 0; k < row; k++)
                        {
                            if (tab[k, j] != '-')
                                result += tab[k, j];
                        }
                    }
                }
            }
            return result;
        }
        public string Decode(string word, string key)
        {
            int row;
            int column;
            int index = 0;
         

            if (word.Length % key.Length == 0)
                row = word.Length / key.Length;
            else
                row = word.Length / key.Length + 1;

            column = key.Length;
            char[,] tab = new char[row, column];
            int empty = row * column - word.Length;
      

            index = key.Length - 1;
           
            for (int i = 0; i < empty; i++)
            {
                tab[row - 1, index] = '-';
                index--;
            }

            index = 0;
            for (int i = 65; i < 91; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if ((int)key[j] == i)
                    {
                        for (int m = 0; m < row; m++)
                        {
                            if (tab[m, j] != '-')
                            {
                                tab[m, j] = word[index];
                                index++;
                            }
                        }
                    }
                }
            }
            string result = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                  
                    if (tab[i,j] != '-')
                        result += tab[i, j];
                }
            }
            return result;
        }
    }
}
