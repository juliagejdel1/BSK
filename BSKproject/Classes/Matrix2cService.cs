using System;
using System.Collections.Generic;
using System.Text;

namespace BSKproject.Classes
{
    public class Matrix2cService
    {
        public string Encode(string word, string key)
        {

            char znak;
            int row= word.Length;
            int column= key.Length;
            int[] lettersKey = new int[key.Length];
            int index = 0;
           
            string password = "";

            char[,] tab = new char[row, column];

            for (int i = 65; i < 91; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (i == (int)key[j])
                    {
                        lettersKey[j] = index++;
                   
                    }
                }
            }

            for (int a = 0; a < word.Length; a++)
            {
                if (word[a] != ' ')
                    password += word[a];
            }

            index = 0;
            bool CountRow = false;
           
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (index < password.Length && !CountRow)
                    {
                        tab[i, j] = password[index];
                        index++;

                        if (i % lettersKey.Length == lettersKey[j])
                            CountRow = true;
                    }
                    else
                        tab[i, j] = '-';
                }
                CountRow = false;
            }
            string result = "";
            //CYPTRHGYOARP
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
            int[] lettersKey = new int[key.Length];
            int index = 0;
            bool CountRow = false;
    
         

            row = word.Length;
            column = key.Length;
            char[,] tab = new char[row, column];

            for (int i = 65; i < 91; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (i == (int)key[j])
                    {
                        lettersKey[j] = index++;
                
                    }
                }
            }

            index = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (index < word.Length && !CountRow)
                    {
                        index++;

                        if (i % lettersKey.Length == lettersKey[j])
                            CountRow = true;
                    }
                    else
                        tab[i, j] = '-';
                }
                CountRow = false;
            }

            index = 0;
            for (int i = 65; i < 91; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if ((int)key[j] == i)
                    {
                        for (int k= 0; k < row; k++)
                        {
                            if (tab[k, j] != '-')
                            {
                                tab[k, j] = word[index];
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
                   
                    if (tab[i, j] != '-')
                        result += tab[i, j];
                }
            }
           return result;


        }
    }
}
