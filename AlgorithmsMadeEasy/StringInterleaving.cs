using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class StringInterleaving
    {
        public void StringInterleavingMethod()
        {
            var string1 = System.Console.ReadLine();
            var string2 = System.Console.ReadLine();
            var string3 = System.Console.ReadLine();

            char[] aString1 = string1.ToCharArray();
            char[] aString2 = string2.ToCharArray();
            char[] aString3 = string3.ToCharArray();

            char[,] matrix = new char[aString2.Length + 1, aString1.Length + 1];

            for (int i = 0; i <= aString2.Length; i++)
            {
                for (int j = 0; j <= aString1.Length; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        matrix[i, j] = 'T';
                        continue;
                    }

                    if (i == 0)
                    {
                        if (aString3[j - 1].Equals(aString1[j - 1]) && matrix[i, j - 1].Equals('T'))
                        {
                            matrix[i, j] = 'T';
                        }
                        else
                        {
                            matrix[i, j] = 'F';
                        }

                        continue;
                    }

                    if (j == 0)
                    {
                        if (aString3[i - 1].Equals(aString2[i - 1]) && matrix[i - 1, j].Equals('T'))
                        {
                            matrix[i, j] = 'T';
                        }
                        else
                        {
                            matrix[i, j] = 'F';
                        }

                        continue;
                    }


                    int k = i + j - 1;
                    int i1 = i - 1;
                    int j1 = j - 1;
                    if (aString3[k].Equals(aString1[j1]) && aString3[k].Equals(aString2[i1]))
                    {
                        if (matrix[i - 1, j].Equals('T'))
                        {
                            matrix[i, j] = 'T';
                        }
                        else
                        {
                            matrix[i, j] = 'F';
                        }
                    }
                    else if (aString3[k].Equals(aString1[j1]))
                    {
                        if (matrix[i, j - 1].Equals('T'))
                        {
                            matrix[i, j] = 'T';
                        }
                        else
                        {
                            matrix[i, j] = 'F';
                        }
                    }
                    else if (aString3[k].Equals(aString2[i1]))
                    {
                        if (matrix[i - 1, j].Equals('T'))
                        {
                            matrix[i, j] = 'T';
                        }
                        else
                        {
                            matrix[i, j] = 'F';
                        }
                    }
                    else
                    {
                        matrix[i, j] = 'F';
                    }

                }
            }

            System.Console.WriteLine(matrix[aString2.Length, aString1.Length]);
            System.Console.ReadLine();
        }
    }
}

/*
 * Sample Input
aab
axy
aaxaby
*/